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
                    case 4:

                        foreach (Room room in rooms)
                        {
                            room.displayRoom();
                            Console.WriteLine();
                        }

                        break;
                    case 5:

                        foreach (Guest guest1 in guests)
                        {
                            guest1.displayGuest();
                        }

                        break;
                    case 6:

                        Console.Write("Enter Room Type: ");
                        string searchType = Console.ReadLine();

                        foreach (Room room in rooms)
                        {
                            if (room.roomType == searchType)
                            {
                                room.displayRoom();
                            }
                        }

                        break;
                    case 7:

                        Console.WriteLine($"Total Rooms: {rooms.Count}");
                        Console.WriteLine($"Total Guests: {guests.Count}");

                        int available = 0;

                        foreach (Room room in rooms)
                        {
                            if (room.isAvailable)
                            {
                                available++;
                            }
                        }

                        Console.WriteLine($"Available Rooms: {available}");

                        break;
                    case 8:

                        Console.Write("Enter Room Number: ");
                        int updateRoom =
                            int.Parse(Console.ReadLine());

                        Room roomUpdate =
                            rooms.FirstOrDefault(
                                r => r.roomNumber == updateRoom);

                        if (roomUpdate != null)
                        {
                            Console.Write("Enter New Price: ");
                            double newPrice =
                                double.Parse(Console.ReadLine());

                            roomUpdate.pricePerNight = newPrice;

                            Console.WriteLine(
                                "Price Updated Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Room Not Found!");
                        }

                        break;
                    case 9:

                        Console.Write("Enter Guest ID: ");
                        string id = Console.ReadLine();

                        Guest foundGuest =
                            guests.FirstOrDefault(
                                g => g.guestId == id);

                        if (foundGuest != null)
                        {
                            foundGuest.displayGuest();
                        }
                        else
                        {
                            Console.WriteLine("Guest Not Found!");
                        }

                        break;
                    case 10:

                        foreach (Room room in rooms)
                        {
                            room.displayRoom();
                            Console.WriteLine("----------------");
                        }

                        break;
                    case 11:

                        Console.Write("Enter Room Number: ");
                        int checkoutRoom =
                            int.Parse(Console.ReadLine());

                        Room roomCheckout =
                            rooms.FirstOrDefault(
                                r => r.roomNumber == checkoutRoom);

                        if (roomCheckout != null)
                        {
                            roomCheckout.isAvailable = true;

                            Console.WriteLine(
                                "Check Out Completed!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Room Not Found!");
                        }

                        break;
                    case 12:

                        Console.Write("Enter Room Number: ");
                        int removeRoom =
                            int.Parse(Console.ReadLine());

                        Room roomRemove =
                            rooms.FirstOrDefault(
                                r => r.roomNumber == removeRoom);

                        if (roomRemove != null)
                        {
                            rooms.Remove(roomRemove);

                            Console.WriteLine(
                                "Room Removed!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Room Not Found!");
                        }

                        break;
                    case 13:

                        Console.Write("Enter Guest ID: ");
                        string guestID =
                            Console.ReadLine();

                        Guest guestExtend =
                            guests.FirstOrDefault(
                                g => g.guestId == guestID);

                        if (guestExtend != null)
                        {
                            Console.Write(
                                "Enter Additional Nights: ");

                            int extra =
                                int.Parse(Console.ReadLine());

                            guestExtend.totalNights += extra;

                            Console.WriteLine(
                                "Stay Extended Successfully!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Guest Not Found!");
                        }

                        break;
                    case 14:

                        double highest = 0;
                        string highestGuestName = "";

                        foreach (Guest g in guests)
                        {
                            double total =
                                g.calculateTotalCost(rooms);

                            if (total > highest)
                            {
                                highest = total;
                                highestGuestName = g.guestName;
                            }
                        }

                        Console.WriteLine(
                            $"Highest Revenue Guest: {highestGuestName}");

                        Console.WriteLine(
                            $"Amount: {highest}");

                        break;
                    case 15:

                        int count = 0;

                        foreach (Room room in rooms)
                        {
                            room.displayRoom();

                            count++;

                            if (count % 3 == 0)
                            {
                                Console.WriteLine(
                                    "Press Enter to continue...");
                                Console.ReadLine();
                            }
                        }

                        break;
                }
            }

        }
    }
}
