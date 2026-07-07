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
        // Task 7 - Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        // Task 8 - Countdown Function
        static void Countdown(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        // Task 9 - Overloaded Multiply Functions
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
