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
                    case 1:

                        Console.Write("Enter Room Number: ");
                        int roomNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter Room Type: ");
                        string roomType = Console.ReadLine();

                        Console.Write("Enter Price Per Night: ");
                        double price = double.Parse(Console.ReadLine());

                        Room newRoom = new Room(
                            roomNumber,
                            roomType,
                            price,
                            true);

                        rooms.Add(newRoom);

                        Console.WriteLine("Room Added Successfully!");

                        break;
                    case 2:

                        Console.Write("Guest ID: ");
                        string guestId = Console.ReadLine();

                        Console.Write("Guest Name: ");
                        string guestName = Console.ReadLine();

                        Console.Write("Room Number: ");
                        string guestRoom = Console.ReadLine();

                        Console.Write("Check In Date: ");
                        string date = Console.ReadLine();

                        Console.Write("Total Nights: ");
                        int nights = int.Parse(Console.ReadLine());

                        Guest guest = new Guest(
                            guestId,
                            guestName,
                            guestRoom,
                            date,
                            nights);

                        guests.Add(guest);

                        Console.WriteLine("Guest Registered!");

                        break;
                    case 3:

                        Console.Write("Enter Room Number: ");
                        int bookRoom =
                            int.Parse(Console.ReadLine());

                        Room roomToBook =
                            rooms.FirstOrDefault(
                                r => r.roomNumber == bookRoom);

                        if (roomToBook != null)
                        {
                            roomToBook.isAvailable = false;

                            Console.WriteLine(
                                "Room Booked Successfully!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Room Not Found!");
                        }

                        break;

                }
            }

        }
    }
}
