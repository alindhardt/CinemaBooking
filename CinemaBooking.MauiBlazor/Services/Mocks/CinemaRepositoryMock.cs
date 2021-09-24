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
    public class CinemaRepositoryMock : ICinemaRepository
    {
        public List<CinemaModel> GetCinemas()
        {
            throw new NotImplementedException();
        }
        public List<CinemaModel> GetCinemas(Func<CinemaModel, bool> predicate)
        {
            throw new NotImplementedException();
        }
        public CinemaModel GetCinemaById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CinemaModel>> GetCinemasAsync()
        {
            using var stream = await Microsoft.Maui.Essentials.FileSystem.OpenAppPackageFileAsync("cinemas.json");

            using var reader = new StreamReader(stream);

            var fileContents = await reader.ReadToEndAsync();

            var result = JsonConvert.DeserializeObject<CinemasJsonResult>(fileContents);

            return result.Cinemas;
        }
        public async Task<List<CinemaModel>> GetCinemasAsync(Func<CinemaModel, bool> predicate)
        {
            var cinemas = await GetCinemasAsync();
            return cinemas.Where(predicate).ToList();
        }
        public async Task<CinemaModel> GetCinemaByIdAsync(int id)
        {
            var cinemas = await GetCinemasAsync();
            return cinemas.SingleOrDefault(c => c.Id == id);
        }
    }
    class CinemasJsonResult
    {
        public List<CinemaModel> Cinemas { get; set; }
    }
}
