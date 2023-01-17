using System;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=========Input Information=============");
            Console.WriteLine("Input type dog: ");
            string typedog=Console.ReadLine();
            Console.WriteLine("Input name dog: ");
            string namedog = Console.ReadLine();
            Console.WriteLine("Input breed dog: ");
            string breeddog = Console.ReadLine();
            Animal d = new Dog(typedog,namedog,breeddog);
            //Animal d= new Dog("Spaniel", "Chihuahua", "Collie");
            Console.WriteLine("Input type cat: ");
            string typecat = Console.ReadLine();
            Console.WriteLine("Input name cat: ");
            string namecat = Console.ReadLine();
            Animal c = new Cat(typecat, namecat);
            //Animal c = new Cat("Mamals", "Miu");
            Console.WriteLine("Input type duck: ");
            string typeduck = Console.ReadLine();
            Console.WriteLine("Input name duck: ");
            string nameduck = Console.ReadLine();
            Animal du = new Duck(typeduck, nameduck);
            //Animal du = new Duck("Bird", "Duck");
            Console.WriteLine("=========Ouput Information=============");
            Console.WriteLine(d.Infomation());
            Console.WriteLine(du.Infomation());
            Console.WriteLine(c.Infomation());
            Console.WriteLine("======================================");
            Console.WriteLine("Input climb cat: ");
            string climbcat = Console.ReadLine();
            Console.WriteLine("Cat is climb:" + ((Cat)c).Climb(climbcat));
            //Console.WriteLine("Cat is climb:" + ((Cat)c).Climb("Tree"));
            //Console.WriteLine("Cat is climb:" + ((Cat)c).Climb("wall"));
            //Console.WriteLine("Cat is climb:" + ((Cat)c).Climb("roof"));

        }
    }
    abstract class Animal
    {
        public Animal(string type)
        {
            this.type = type;
        }
        public string type;
        public abstract string Sound();
        public abstract string Infomation();
    }
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string type, string name) : base(type)
        {
            this.Name = name;
        }
        public string Climb(string ClimO)
        { return ClimO; }

        public override string Sound()
        {
            return "MeoMeoMeo";
        }

        public override string Infomation()
        {
            return "This is a Cat\n Name = " + Name + "\n Type =" + type + "\n Sound = " + Sound() + "\n";
        }
    }
    class Dog : Animal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Dog(string type,string name,string breed) : base(type)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public override string Infomation()
        {
            return "This is a Dog\n Name = " + Name + "\n Breed= " + Breed + "\n Type= " + type + "\n Sound= " + Sound();
        }

        public override string Sound()
        {
            return "GauGauGau";
        }
    }
    class Duck : Animal
    {
        public string Name { get; set; }
        public Duck(string type,string name) : base(type)
        {
            this.Name = name;
        }
        public string Swim(string SwimO)
        {
            return SwimO;
        }
        public override string Infomation()
        {
            return "This is a Duck\n Name = " + Name + "\n Type= " + type + "\n Sound= " + Sound();
        }

        public override string Sound()
        {
            return "QuakQuak";
        }
    }
}