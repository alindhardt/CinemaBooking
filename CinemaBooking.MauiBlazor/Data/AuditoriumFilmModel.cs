using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Data
{
    public class AuditoriumFilmModel
    {
        public int AuditoriumId { get; set; }
        public AuditoriumModel Auditorium { get; set; }
        public int FilmId { get; set; }
        public FilmModel Film { get; set; }
        public DateTime StartTime { get; set; }
    }
}
