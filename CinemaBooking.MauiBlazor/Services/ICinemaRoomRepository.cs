using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services
{
    public interface ICinemaRoomRepository

    {
        List<SeatModel> GetSeatsFromRoom(int cinemaId, int roomId, DateTime filmStartTime);
        Task<List<SeatModel>> GetSeatsFromRoomAsync(int CinemaId, int roomId, DateTime filmStartTime);
    }
}