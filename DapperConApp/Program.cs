﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DapperConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(GetSeats), null);

            ThreadPool.QueueUserWorkItem(new WaitCallback(GetSeatBySeatId), null);

            ThreadPool.QueueUserWorkItem(new WaitCallback(GetSeats), null);

            int total = DataAccess.Data.CountSeats(0, 0, 0, 0);
            Console.WriteLine("Total seats: {0}", total.ToString("# ### ### ###"));

            Console.ReadLine();
        }

        private static void GetSeatBySeatId(object obj)
        {
            Console.WriteLine("GetSeatBySeatId Thread {0} started", Thread.CurrentThread.GetHashCode());
            int[] seatIds = { 9228120, 9228105, 9228094, 9228093, 9228092, 9228091, 9227749, 9227747, 9227744, 9227742, 9228261};

            foreach (int id in seatIds)
            {
                Seat seat = DataAccess.Data.GetSeatBySeatId(id);
                Print(seat);
                Console.WriteLine();
            }
        }

        private static void GetSeats(object obj)
        {
            Console.WriteLine("GetSeats Thread {0} started", Thread.CurrentThread.GetHashCode());
            int memberId = 273;
            int eventId = 5064;
            int statusId = 4;

            IEnumerable<Seat> seats = DataAccess.Data.GetSeats(memberId, eventId, statusId);
            Print(seats);
        }

        static void Print(Seat seat)
        {
            Console.WriteLine("Id: {0} Row: {1} Seat: {2}", seat.Id, seat.RowNum, seat.SeatNum);
            Console.WriteLine();
        }

        static void Print(IEnumerable<Seat> seats)
        {
            int counter = 0;
            foreach (Seat seat in seats)
            {
                counter++;
                Console.WriteLine("#{3}. Id: {0} Row: {1} Seat: {2}", seat.Id, seat.RowNum, seat.SeatNum, counter);
            }

            Console.WriteLine();
        }
    }
}
