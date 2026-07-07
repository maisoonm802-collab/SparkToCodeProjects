namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void FixedGradesArray()
            {
                int[] grades = new int[5];

                for (int i = 0; i < grades.Length; i++)
                {
                    Console.Write($"Enter grade {i + 1}: ");
                    grades[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nStudent Grades:");

                foreach (int grade in grades)
                {
                    Console.WriteLine(grade);
                }
            }
        
      // Task 2 - Dynamic To-Do List
      
            List<string> tasks = new List<string>();

            for (int i = 0; i< 5; i++)
            {
                Console.Write($"Enter task {i + 1}: ");
                tasks.Add(Console.ReadLine());
            }

    Console.WriteLine("\nTo-Do List:");

            int number = 1;

            foreach (string task in tasks)
            {
                Console.WriteLine($"{number}. {task}");
                number++;
            }
            // Task 3 - Browser History Stack
            // ==========================

            static void BrowserHistoryStack()
            {
                Stack<string> history = new Stack<string>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter website URL {i + 1}: ");
                    history.Push(Console.ReadLine());
                }

                history.Pop();

                Console.WriteLine($"Current page: {history.Peek()}");
            }
            
            // Task 4 - Customer Service Queue
        
            static void CustomerServiceQueue()
            {
                Queue<string> customers = new Queue<string>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter customer name {i + 1}: ");
                    customers.Enqueue(Console.ReadLine());
                }

                string servedCustomer = customers.Dequeue();

                Console.WriteLine($"Served customer: {servedCustomer}");
            }

