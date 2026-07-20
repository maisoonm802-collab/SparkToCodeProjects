using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Mangment_System
{
    internal class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;

        public Guest(string guestId,
                     string guestName,
                     string roomNumber,
                     string checkInDate,
                     int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }
    }
}

