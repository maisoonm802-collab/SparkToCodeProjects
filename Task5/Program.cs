namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personalized Welcome Function
            static void PrintWelcome(string name)
            {
                Console.WriteLine("Welcome, " + name + "!");
            }
        }

        // Task 2 - Square Number Function
        static int Square(int number)
        {
            return number * number;
        }
        // Task 3 - Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        // Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        // Task 5 - Even or Odd Function
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        // Task 6 - Rectangle Area &Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
