using System.Linq;
namespace Hotel_Mangment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(101, "Single", 20, true));
            rooms.Add(new Room(102, "Single", 25, true));
            rooms.Add(new Room(201, "Double", 35, true));
            rooms.Add(new Room(202, "Double", 40, true));
            rooms.Add(new Room(301, "Suite", 60, true));
            rooms.Add(new Room(302, "Suite", 80, true));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== Hotel Management System =====");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book Room");
                Console.WriteLine("4. View Rooms");
                Console.WriteLine("5. View Guests");
                Console.WriteLine("6. Search Rooms");
                Console.WriteLine("7. Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup");
                Console.WriteLine("10. Room Report");
                Console.WriteLine("11. Check Out");
                Console.WriteLine("12. Remove Rooms");
                Console.WriteLine("13. Extend Stay");
                Console.WriteLine("14. Highest Revenue");
                Console.WriteLine("15. Pagination");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;
                }
            }

        }
    }
}
