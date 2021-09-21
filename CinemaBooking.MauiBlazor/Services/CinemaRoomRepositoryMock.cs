using CinemaBooking.MauiBlazor.Data;
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

            return new List<SeatModel>
            {
                new SeatModel { RowNumber = 1, SeatNumber = 1, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 2, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 3, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 4, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 5, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 6, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 7, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 8, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 9, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 1, SeatNumber = 10, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 1, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 2, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 3, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 4, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 5, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 6, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 7, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 8, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 9, SeatStatus = RandomSeatStatus(rand) },
                new SeatModel { RowNumber = 2, SeatNumber = 10, SeatStatus = RandomSeatStatus(rand) }
            };
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
