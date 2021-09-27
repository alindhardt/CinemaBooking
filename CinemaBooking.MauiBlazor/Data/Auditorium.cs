using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Data
{
    public class Auditorium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rows { get; set; }
        public int TotalNumberOfSeats { get; set; }
        public List<SeatModel> Seats { get; set; }
    }
}
