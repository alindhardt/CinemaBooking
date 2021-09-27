using CinemaBooking.MauiBlazor.Data;
using CinemaBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Pages
{
    public partial class CinemaList
    {
        [Inject]
        public ICinemaRepository CinemaRepository { get; set; }

        public List<CinemaModel> Cinemas { get; set; } = new List<CinemaModel>();

        protected override async Task OnInitializedAsync()
        {
            Cinemas = await CinemaRepository.GetCinemasAsync();
        }
    }
}
