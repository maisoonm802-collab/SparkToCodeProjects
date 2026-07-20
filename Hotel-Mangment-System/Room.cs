using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Mangment_System
{
    internal class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int roomNumber,
                    string roomType,
                    double pricePerNight,
                    bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void displayRoom()
        {
            Console.WriteLine($"Room Number : {roomNumber}");
            Console.WriteLine($"Room Type   : {roomType}");
            Console.WriteLine($"Price       : OMR {pricePerNight:F2}");
            Console.WriteLine($"Available   : {isAvailable}");
        }
    }
}

