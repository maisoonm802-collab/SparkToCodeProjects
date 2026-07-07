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
        }
    }
}
