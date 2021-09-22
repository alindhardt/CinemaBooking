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
    public partial class FilmList
    {
        [Inject]
        public IFilmRepository FilmRepository { get; set; }

        [Parameter]
        public List<FilmModel> Films { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (Films is null)
            {
                Films = await FilmRepository.GetFilmsAsync();
            }
        }
    }
}
