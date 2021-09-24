using CinemaBooking.MauiBlazor.Data;
using CinemaBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Shared
{
    public partial class FilmTimePicker
    {
        [Parameter]
        public List<DateTime> ShowTimes { get; set; }
        [Parameter]
        public List<DateTime> ColumnDates { get; set; } = new List<DateTime>()
        {
            DateTime.Now,
            DateTime.Now.AddDays(1),
            DateTime.Now.AddDays(2),
            DateTime.Now.AddDays(3)
        };
        [Parameter]
        public EventCallback<DateTime> TimeSelectedCallback { get; set; }

        async Task TimeSelected(DateTime time)
        {
            await TimeSelectedCallback.InvokeAsync(time);
        }
    }
}
