using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services
{
    public interface ICinemaRepository
    {
        CinemaModel GetCinemaById(int id);
        Task<CinemaModel> GetCinemaByIdAsync(int id);
        List<CinemaModel> GetCinemas();
        List<CinemaModel> GetCinemas(Func<CinemaModel, bool> predicate);
        Task<List<CinemaModel>> GetCinemasAsync();
        Task<List<CinemaModel>> GetCinemasAsync(Func<CinemaModel, bool> predicate);
    }
}