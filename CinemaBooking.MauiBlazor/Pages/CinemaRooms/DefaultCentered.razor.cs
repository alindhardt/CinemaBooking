using CinemaBooking.MauiBlazor.Data;
using CinemaBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Pages.CinemaRooms
{
    public partial class DefaultCentered
    {
        [Inject]
        public ICinemaRoomRepository CinemaRoomRepository { get; set; }

        public int NumberOfSeatsPicked { get; private set; }
        public List<SeatModel> Seats { get; set; } = new List<SeatModel>();

        protected override async Task OnInitializedAsync()
        {
            Seats = await CinemaRoomRepository.GetSeatsFromRoomAsync(1, 1, DateTime.Now);
        }

        void UpdateNumberOfSeatsPicked()
        {
            NumberOfSeatsPicked = Seats.Where(s => s.SeatStatus is SeatStatus.Picked).Count();
        }
    }
}
