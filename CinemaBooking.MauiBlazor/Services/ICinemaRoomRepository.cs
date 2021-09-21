using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services
{
    public interface ICinemaRoomRepository

    {
        Task<List<SeatModel>> GetSeatsFromRoom(int CinemaId, int roomId, DateTime startTime);
    }
}