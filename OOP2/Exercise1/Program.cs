using System;
using System.Drawing;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line();
            Rectangle();
            Circle();
        }
        static void Test(Shape shape)
        {
            Console.WriteLine("Before move:");
            shape.Show();
            shape.Move(9, 9);
            Console.WriteLine("After move:");
            shape.Show();
        }

        static void Line()
        {
            try
            {
                Console.WriteLine("Line ");
                var point1 = InputPoint("FirstPoint");
                var point2 = InputPoint("SecondPoint");
                Line line = new Line(point1, point2);
                Test(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ");
            }

        }
        static void Circle()
        {
            try
            {
                Console.WriteLine(" Line ");
                var center = InputPoint("CenterPoint");
                double radius = InputDoubleNumber("Radius");
                Circle circle = new Circle(center, radius);
                Test(circle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ");
            }

        }
        static void Rectangle()
        {
            try
            {
                Console.WriteLine("Rectangle ");
                var point1 = InputPoint("FirstPoint");
                var point2 = InputPoint("SecondPoint");
                var point3 = InputPoint("ThirdPoint");
                var rectangle = new Rectangle(point1, point2, point3);
                Test(rectangle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }
        }
        static void PolyLine()
        {
            try
            {
                Console.WriteLine("PolyLine ");
                int number = InputIntNumber("NumberOfPoints");
                List<Point> points = new List<Point>();
                if (number <= 1) throw new Exception("Exception");
 for (int i = 1; i <= number; i++)
                {
                    points.Add(InputPoint("Point number " + i));
                }
                PolyLine polyLine = new PolyLine(points);
                Test(polyLine);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception  "+e);
            }
        }
        static Point InputPoint(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + ": X = ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write(s + ": Y = ");
                    int y = int.Parse(Console.ReadLine());
                    return new Point(x, y);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Errors" + s + ", again!");
                }
            }
        }
        static double InputDoubleNumber(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " = ");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Errors" + s + ", again!");
                }
            }
        }
        static int InputIntNumber(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " = ");
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Errors" + s + ", again!");
                }
            }
        }
    }


    public class Point
    {
        public float x { get; set; }
        public float y { get; set; }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public abstract class Shape
    {
        protected List<Point> points;
        protected string Name { get; set; }
        public abstract void Show();
        public void Move(int x, int y)
        {
            foreach (Point i in points)
            {
                i.x += x;
                i.y += y;
            }
        }
    }
    public class Line : Shape
    {
    private string name;

    private double d { get; set; }
        public Line(Point a, Point b)
        {
            name = "Line";
            points = new List<Point>();
            points.Add(a);
            points.Add(b);
            d = Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2));
        }
        public override void Show()
        {
            Console.WriteLine("This is a " + name + ", with:");
            foreach (Point i in points)
            {
                Console.WriteLine("Point " + points.IndexOf(i) + " [X = " + i.x +" , Y = " + i.y + "]");
            }
            Console.WriteLine("Length = " + d);
        }
        public void Move(Point point, int x, int y)
        {
            if (points.Contains(point))
            {
                point.x += x;
                point.y += y;
            }
        }
    }
    public class PolyLine : Shape
    {
    private string name;

    public PolyLine(List<Point> a)
        {
            points = new List<Point>();
            name = "PolyLine";
            foreach (Point i in a)
            {
                points.Add(i);
            }

        }
        public override void Show()
        {
            Console.WriteLine("This is a " + name + ", with:");
            foreach (Point i in points)
            {
                Console.WriteLine("Point " + points.IndexOf(i) + " [X = " + i.x + " , Y = " + i.y + "]");
            }
        }
        public void Move(Point point, int x, int y)
        {
            if (points.Contains(point))
            {
                point.x += x;
                point.y += y;
            }
        }
    }
    public class Rectangle : Shape
    {
    private string name;

    public Rectangle(Point a, Point b, Point c)
        {
            points = new List<Point>();
            name = "Rectangle";
            points.Add(a);
            points.Add(b);
            points.Add(c);
        }
        public override void Show()
        {
            Console.WriteLine("This is a " + name + ", with:");
            foreach (Point i in points)
            {
                Console.WriteLine("Point " + points.IndexOf(i) + " [X = " + i.x + " , Y = " + i.y + "]");
            }
        }
        public void Move(Point point, int x, int y)
        {
            if (points.Contains(point))
            {
                point.x += x;
                point.y += y;
            }
        }
    }
    public class Circle : Shape
    {
    private string name;

    private double r { get; set; }
        public Circle(Point o, double r)
        {
            points = new List<Point>();
            name = "Circle";
            points.Add(o);
            this.r = r;
        }
        public override void Show()
        {
            Point p = points.FirstOrDefault();
            Console.WriteLine("This is a " + name + ", with center[ " + p.x + " , "+p.y+" ] and radius = "+r);
        }
        public void Move(Point point, int x, int y)
        {
            if (points.Contains(point))
            {
                point.x += x;
                point.y += y;
            }
        }
    }


}
