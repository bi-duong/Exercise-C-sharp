using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dice dice = new Dice();
            int sid;

            Console.Write("Enter a number of sides of Dice: ");
            sid = Convert.ToInt32(Console.ReadLine());

            try
            {
                dice.Side = sid;

                Console.WriteLine($"Results after Random Random: {dice.roll()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Dice
    {
        private int side;
        public int Side
        {
            get { return side; }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException("Number of dice faces from 1 to 6");
                }

                side = value;
            }
        }
        public int roll()
        {
            Random rd = new Random();

            return rd.Next(1, Side + 1);
        }
    }

}
