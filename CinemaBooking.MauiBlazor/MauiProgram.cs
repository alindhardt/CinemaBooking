using CinemaBooking.MauiBlazor.Data;
using CinemaBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace CinemaBooking.MauiBlazor
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .RegisterBlazorMauiWebView()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddTransient<ICinemaRepository, Services.Mocks.CinemaRepositoryMock>();
            builder.Services.AddTransient<ICinemaRoomRepository, Services.Mocks.CinemaRoomRepositoryMock>();
            builder.Services.AddTransient<IFilmRepository, Services.Mocks.FilmRepositoryMock>();
            builder.Services.AddBlazorWebView();
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}