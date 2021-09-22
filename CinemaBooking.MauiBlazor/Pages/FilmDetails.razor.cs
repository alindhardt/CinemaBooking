using CinemaBooking.MauiBlazor.Data;
using CinemaBooking.MauiBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.MauiBlazor.Pages
{
    public partial class FilmDetails
    {
        [Inject]
        public IFilmRepository FilmRepository { get; set; }

        [Parameter]
        public FilmModel Film { get; set; }
        public bool DescriptionExpanded { get; set; }
        public string DanishPremiere { get => Film.PremiereDate.ToString("dd. MMM yyyy", new CultureInfo("da-DK")); }
        public string TitleFontSize 
        { 
            get 
            {
                var size = "4rem";
                if (Film?.Name is not null)
                {
                    var longestWordLength = LengthOfLongestWord(Film.Name);
                    if (longestWordLength > 15)
                        size = "1.3rem";
                    else if (longestWordLength > 8)
                        size = "2.3rem";
                }
                return size;
            } 
        }

        public void ToggleDescriptionExpanded() => DescriptionExpanded = !DescriptionExpanded;

        int LengthOfLongestWord(string text)
        {
            var length = 0;

            if (string.IsNullOrWhiteSpace(text) is false)
            {
                var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = text.Split().Select(x => x.Trim(punctuation));

                if (words.Count() > 0)
                {
                    return words
                        .OrderByDescending(w => w.Length)
                        .First().Length;
                }
            }

            return length;
        }

        async Task TestAsync()
        {
            var films = await FilmRepository.GetFilmsAsync();
        }

        protected async override Task OnInitializedAsync()
        {
            if (Film is null)
            {
                Film = await FilmRepository.GetFilmByIdAsync(1);
            }
        }
    }
}
