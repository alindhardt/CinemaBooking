﻿using CinemaBooking.MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Pages
{
    public partial class CinemaList
    {
        public List<CinemaModel> Cinemas { get; set; } = new List<CinemaModel>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(150);

            Cinemas = new List<CinemaModel>()
            {
                new CinemaModel
                {
                    Name = "NORDISK FILM BIOGRAFER FIELDS",
                    City = "København",
                    Country = "Danmark",
                    Address = @"Nordisk Film Biografer Field's
Ørestads Boulevard 102A
2300 København S"
                },
                new CinemaModel
                {
                    Name = "NORDISK FILM BIOGRAFER VIBORG FOTORAMA",
                    City = "Viborg",
                    Country = "Danmark",
                    Address = @"Tingvej 4

8800 Viborg"
                }
            };
        }
    }
}