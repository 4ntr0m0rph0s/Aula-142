﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
            RoomNumber = roomNumber;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room " +
                +RoomNumber
                + ", check-in: "
                + CheckIn.ToString(" dd/mm/yyyy ")
                + ", Check-out: "
                + ","
                + CheckOut.ToString(" dd/mm/yyyy ")
                + Duration()
                + " nights ";
        }
    }
}
