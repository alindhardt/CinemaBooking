using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services
{
    public interface IFilmRepository
    {
        FilmModel GetFilmById(int id);
        Task<FilmModel> GetFilmByIdAsync(int id);
        List<FilmModel> GetFilms();
        List<FilmModel> GetFilms(Func<FilmModel, bool> predicate);
        Task<List<FilmModel>> GetFilmsAsync();
        Task<List<FilmModel>> GetFilmsAsync(Func<FilmModel, bool> predicate);
    }
}