using System.Threading.Channels;

namespace Shape_Interface_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ___           _                  _           _                                                    \r\n(  _`\\        (_ )               (_ )        ( )_                                                  \r\n| ( (_)   _ _  | |    ___  _   _  | |    _ _ | ,_)   __                                            \r\n| |  _  /'_` ) | |  /'___)( ) ( ) | |  /'_` )| |   /'__`\\                                          \r\n| (_( )( (_| | | | ( (___ | (_) | | | ( (_| || |_ (  ___/                                          \r\n(____/'`\\__,_)(___)`\\____)`\\___/'(___)`\\__,_)`\\__)`\\____)                                          \r\n                                                                                                   \r\n                                                                                                   \r\n _____                        _____       ___                                     _                \r\n(  _  )                      (  _  )     (  _`\\              _                   ( )_              \r\n| (_) | _ __   __     _ _    `\\  ,/'     | |_) )  __   _ __ (_)  ___ ___     __  | ,_)   __   _ __ \r\n|  _  |( '__)/'__`\\ /'_` )    /'_`\\/\\    | ,__/'/'__`\\( '__)| |/' _ ` _ `\\ /'__`\\| |   /'__`\\( '__)\r\n| | | || |  (  ___/( (_| |   | (_> ,<`   | |   (  ___/| |   | || ( ) ( ) |(  ___/| |_ (  ___/| |   \r\n(_) (_)(_)  `\\____)`\\__,_)   `\\___/\\/'   (_)   `\\____)(_)   (_)(_) (_) (_)`\\____)`\\__)`\\____)(_)   \r\n                                                                                                   \r\n                                                                                                   ");

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