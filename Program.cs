using System.Threading.Channels;

namespace Shape_Interface_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate circle and square (CalculateArea, CalculatePerimeter)\n\n");

            Console.Write("number is: ");
            double number = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("\n\nCircle");
            var circle = new Circle(number);

            Console.WriteLine("CalculateArea: " + circle.CalculateArea().ToString("F2"));
            Console.WriteLine("CalculatePerimeter: " + circle.CalculatePerimeter().ToString("F2"));



            Console.WriteLine("\n\nSquare");
            var square = new Square(number);

            Console.WriteLine("CalculateArea: " + square.CalculateArea().ToString("F2"));
            Console.WriteLine("CalculatePerimeter: " +  square.CalculatePerimeter().ToString("F2"));


        }
    }
}