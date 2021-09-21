using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Data
{
    public class SeatModel
    {
        public SeatStatus SeatStatus { get; set; }
        public string RowName { get; set; }
        public int SeatNumber { get; set; }
    }
}
