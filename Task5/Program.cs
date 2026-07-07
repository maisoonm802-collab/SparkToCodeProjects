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
