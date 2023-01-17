using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fraction fran1 = new Fraction();
            fran1.Input();
            Console.WriteLine("====Ouput 1=====");
            fran1.DisplayFraction();
            Fraction fran2 = new Fraction();
            fran2.Input();
            Console.WriteLine("====Ouput 2=====");
            fran2.DisplayFraction();
            Console.WriteLine("====Ouput end=====");
            fran1.Add(fran2);
            fran1.DisplayFraction();
        }
    }
    class Fraction
    {
        private int num;
        private int deno;
        public int Numerator
        {
            get { return num; }
            set { num = value; }
        }
        public int Denominator
        {
            get
            {
                return deno;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("denominator must not be zero");
                }
                deno = value;
            }
        }
        public void Add(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Numerator += this.Denominator * fraction.Numerator;

            this.Denominator *= fraction.Denominator;
        }

        public void Subtract(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Numerator -= this.Denominator * fraction.Numerator;

            this.Denominator *= fraction.Denominator;
        }

        public void Multiply(Fraction fraction)
        {
            this.Numerator *= fraction.Numerator;
            this.Denominator *= fraction.Denominator;
        }

        public void Divide(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Denominator = this.Denominator * fraction.Numerator;
        }
        private void Normalize()
        {
            int gcd = GCD(this.Numerator, this.Denominator);
            this.Numerator /= gcd;
            this.Denominator /= gcd;
        }
        private int GCD(int a, int b)
        {
            if (a % b == 0)
                return b;

            return GCD(b, a % b);
        }
        public void DisplayFraction()
        {
            Normalize();
            Console.WriteLine(this.ToString());
        }
        public void DisplayFractionDecimal()
        {
            Normalize();
            Console.WriteLine(String.Format("{0:0.00}", ToDecimal()));
        }
        private float ToDecimal()
        {
            return (float)((Numerator) / Denominator);
        }
        public override string ToString()
        {
            if (Numerator % Denominator == 0) return $"{Numerator}";
            return Numerator + "/" + Denominator;
        }
        public void Input()
        {
            Console.Write("Enter numerator: ");
            Numerator = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    Console.Write("Enter denominator: ");
                    Denominator = Convert.ToInt32(Console.ReadLine());
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
                break;
            }
        }
    }
}