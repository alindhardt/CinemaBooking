using CinemaBooking.MauiBlazor.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Services.Mocks
{
    public class FilmRepositoryMock : IFilmRepository
    {
        public async Task<List<FilmModel>> GetFilmsAsync()
        {
            await Task.Delay(150);

            try
            {
                using var stream = await Microsoft.Maui.Essentials.FileSystem.OpenAppPackageFileAsync("films.json");

                using var reader = new StreamReader(stream);
                
                var fileContents = await reader.ReadToEndAsync();

                var result = JsonConvert.DeserializeObject<FilmsJsonResult>(fileContents);
                
            }
            catch (Exception ex)
            {
                var exc = ex;
            }



            return GetFilms();
        }

        public async Task<List<FilmModel>> GetFilmsAsync(Func<FilmModel, bool> predicate)
        {
            var films = await GetFilmsAsync();

            return films
                .Where(predicate)
                .ToList();
        }

        public List<FilmModel> GetFilms()
        {
            return new List<FilmModel>
            {
                new FilmModel
                {
                    Id = 1,
                    Name = "Dune",
                    Descriptions = new string[]
                    {
                        "Science fiction-filmen 'Dune' er baseret på Frank Herberts roman (på dansk ’Klit’) fra 1965, som i 1984 blev filmatiseret af David Lynch.",
                        "Den unge hertugsøn Paul Atreides vikles ind i galaksens mest indædte politiske magtkampe, hvor krydderiet Melange er altbetydende for herredømmet.",
                        "Bag filmen står Denis Villeneuve, den ukuelige filmskaber bag bl.a. 'Sicario', 'Arrival' og 'Blade Runner 2049'. Call Me By Your Name-skuespilleren Timothée Chalamet skal overtage rollen som Atreides fra Kyle MacLachlan, som tidligere portrætterede hertugsønnen i 1984. Modsat Lynch vil Villeneuve få frie tøjler til at føre sin version af Herberts 400 sider til live med en to-delt filmatisering."
                    },
                    PosterImage = "https://www.nfbio.dk/sites/nfbio.dk/files/styles/movie_poster/public/movie-posters/HO00002208_103583.jpg?itok=mfGxaaOu",
                    Categories = new FilmCategory[]
                    {
                        FilmCategory.Adventure,
                        FilmCategory.Drama,
                        FilmCategory.ScienceFiction
                    },
                    Director = "Denis Villeneuve",
                    FilmType = FilmType.TwoD,
                    PremiereDate = new DateTime(2021, 9, 16),
                    PlayTime = new TimeSpan(2, 35, 0),
                    Stars = new string[]
                    {
                        "Timothée Chalamet",
                        "Rebecca Ferguson",
                        "Jason Momoa",
                        "Zendaya",
                        "Josh Brolin",
                        "Oscar Isaac",
                        "Javier Bardem",
                        "Dave Bautista",
                        "Stellan Skarsgård",
                        "Charlotte Rampling"
                    },
                    Rating = 8.5
                }
            };
        }

        public List<FilmModel> GetFilms(Func<FilmModel, bool> predicate)
        {
            return GetFilms()
                .Where(predicate)
                .ToList();
        }

        public async Task<FilmModel> GetFilmByIdAsync(int id)
        {
            var films = await GetFilmsAsync();

            return films.SingleOrDefault(f => f.Id == id);
        }

        public FilmModel GetFilmById(int id)
        {
            return GetFilms().SingleOrDefault(f => f.Id == id);
        }
    }

    class FilmsJsonResult
    {
        public List<FilmModel> Films { get; set; }
    }
}
