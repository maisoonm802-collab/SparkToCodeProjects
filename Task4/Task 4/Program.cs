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

