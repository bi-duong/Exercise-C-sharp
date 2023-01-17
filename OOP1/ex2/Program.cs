using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student st = new Student();
            st.Input();
            Console.WriteLine("\n=====Output=====\n");
            st.DisplayStudent();
        }
    }
    class Person
    {
        public Person() { }
        public Person(string name) => Name = name;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string? name = null;
        private int age = 0;

        public int Age { get { return age; } set { age = value; } }

        public string? Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Ten khong duoc de trong");
                }
                name = value;

            }
        }

        public void DisplayPerson()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Name => {Name} \nAge => {Age}";
        }
        public virtual void Input()
        {
            Console.Write("\nInput Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("\nInput Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Student : Person
    {
        private float gpa = 0.0f;

        public float Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentException("GPA ranges from 1 den 4");
                }
                gpa = value;
            }
        }
        public Student(string name) : base(name)
        {
        }
        public Student() : base()
        {
        }
        public override void Input()
        {
            base.Input();

            Console.Write("Input Enter GPA: ");
            float gpa = 0.0f;
            gpa = Convert.ToSingle(Console.ReadLine());
            Gpa = gpa;
        }
        public void DisplayStudent()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return base.ToString() + $"\nGPA => {String.Format("{0:0.00}", Gpa)}\n";
        }
    }
}