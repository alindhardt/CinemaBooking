using CinemaBooking.MauiBlazor.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Shared
{
    public partial class Seat
    {
        private int _height = 70;
        private int _width = 55;
        private int _borderRadius = 7;
        public string Height { get => $"{_height}px"; }
        public string Width { get => $"{_width}px"; }
        public string BorderRadius { get => $"{_borderRadius}px"; }
        public string Color
        {
            get
            {
                switch (Model.SeatStatus)
                {
                    case SeatStatus.Free:
                        return "green";
                    case SeatStatus.Picked:
                        return "blue";
                    case SeatStatus.Occupied:
                        return "red";
                    case SeatStatus.Reserved:
                        return "white";
                    default:
                        return "gray";
                }
            }
        }

        [Parameter]
        public SeatModel Model { get; set; }

        [Parameter]
        public EventCallback OnSeatStatusChanged { get; set; }

        private async void ToggleSeatStatus()
        {
            if (Model.SeatStatus is not SeatStatus.Occupied or SeatStatus.Reserved)
            {
                if (Model.SeatStatus is SeatStatus.Picked) Model.SeatStatus = SeatStatus.Free;
                else if (Model.SeatStatus is SeatStatus.Free) Model.SeatStatus = SeatStatus.Picked;

                await OnSeatStatusChanged.InvokeAsync();
            }
        }
    }
}
