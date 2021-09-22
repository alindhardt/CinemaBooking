using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Data
{
    public class FilmModel
    {
        public string Name { get; set; }
        public string[] Descriptions {  get; set; }
        public string PosterImage { get; set; }
        public FilmType FilmType { get; set; }
        public FilmCategory[] Categories {  get; set; }
        public string Director { get; set; }
        public string[] Stars { get; set; }
        public TimeSpan PlayTime { get; set; }
        public double Rating { get; set; }
        public DateTime PremiereDate { get; set; }
    }
}
