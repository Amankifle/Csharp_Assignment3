

namespace ConsoleApp1
{
    internal class Program
    {

        abstract class Ishape
        {
            public abstract void calArea();
            public abstract void calPerimeter();
        }
        class Circle : Ishape
        {
            public double radius { get; set; }
            static readonly double PI = 3.14;

            public override void calArea()
            {
                double Area;
                Area = PI * PI * radius;
                Console.WriteLine("The area of this circle is: " + Area);

            }

            public override void calPerimeter()
            {
                double Perimeter;
                Perimeter = 2 * PI * radius;
                Console.WriteLine("The perimeter of this circle is: " + Perimeter);
            }
        }
        class rectangle : Ishape
        {
            public double length { get; set; }
            public double width { get; set; }

            public override void calArea()
            {
                double Area;
                Area = length * width;
                Console.WriteLine("The area of this rectangle is: " + Area);

            }

            public override void calPerimeter()
            {
                double Perimeter;
                Perimeter = 2 * (width + length);
                Console.WriteLine("The perimeter of this rectangle is: " + Perimeter);
            }
        }
        static void Main(string[] args)
        {

            int x;
            do
            {
                Console.WriteLine("1.Calculate area and perimeter of circle\n");
                Console.WriteLine("2.Calculate area and perimeter of rectangle.\n");
                Console.WriteLine("3.Exit.\n");
                do
                {
                    Console.WriteLine("Choose your choice:");
                    x  = Convert.ToInt32(Console.ReadLine());
                    if ((x != 1 && x != 2 && x != 3))
                        Console.WriteLine("Error");
                } while (x != 1 && x != 2 && x != 3);

                if (x == 1)
                {
                    Circle c = new Circle();
                    Console.Write("Enter the radius: ");
                    c.radius = Convert.ToDouble(Console.ReadLine());
                    c.calArea();
                    c.calPerimeter();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (x == 2)
                {

                    rectangle r = new rectangle();
                    Console.Write("Enter the length: ");
                    r.length =  Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    r.width = Convert.ToDouble(Console.ReadLine());
                    r.calArea();
                    r.calPerimeter();
                    Console.ReadLine();
                    Console.Clear();

                }

            } while (x == 1 || x == 2);
        }
    }
}