namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintWelcome(string name)
            {
                Console.WriteLine("Welcome " + name + "!");
            }

            static void Main(string[] args)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                PrintWelcome(name);
            }
            ///Task2\\\\\\\\\\\\
Console.WriteLine("\n--- Task 2 ---");
            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
            ///Task3\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 3 ---");
            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            Console.Write("Enter Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
            ///Task4\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 4 ---");
            
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Help");
                Console.WriteLine("3. Exit");
            DisplayMenu();
            
            ///Task5\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 5 ---");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = IsEven(number);

            if (result)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            ///Task6\\\\\\\\\\\\
            Console.WriteLine("\n--- Task 6 ---");
Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
