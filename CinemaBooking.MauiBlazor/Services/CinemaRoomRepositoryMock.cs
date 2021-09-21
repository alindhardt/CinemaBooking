﻿using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services
{
    public class CinemaRoomRepositoryMock : ICinemaRoomRepository
    {
        public async Task<List<SeatModel>> GetSeatsFromRoom(int cinemaId, int roomId, DateTime startTime)
        {
            await Task.Delay(500);

            var rand = new Random();

            var list = new List<SeatModel>();
            var rows = new string[] { "A", "B", "C", "D", "E" };

            foreach (var row in rows)
            {
                for (int sn = 1; sn < 11; sn++)
                {
                    list.Add(new SeatModel { RowName = row, SeatNumber = sn, SeatStatus = RandomSeatStatus(rand) });
                }
            }

                

            return list;
        }

        /// <summary>
        /// Random except SeatStatus.Picked
        /// </summary>
        /// <returns></returns>
        SeatStatus RandomSeatStatus(Random rand)
        {
            var randomNumber = rand.Next(0, 2);

            if (randomNumber is 0)
                return (SeatStatus)randomNumber;
            else
                return (SeatStatus)randomNumber + 1;
        }
    }
}
