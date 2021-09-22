using CinemaBooking.MauiBlazor.Data;
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

        protected override void OnParametersSet()
        {
            if (Film is null)
            {
                Film = new FilmModel
                {
                    Name = "Dune",
                    Descriptions = new string[]
                    {
                        "Science fiction-filmen 'Dune' er baseret på Frank Herberts roman (på dansk ’Klit’) fra 1965, som i 1984 blev filmatiseret af David Lynch.",
                        "Den unge hertugsøn Paul Atreides vikles ind i galaksens mest indædte politiske magtkampe, hvor krydderiet Melange er altbetydende for herredømmet.",
                        "Bag filmen står Denis Villeneuve, den ukuelige filmskaber bag bl.a. 'Sicario', 'Arrival' og 'Blade Runner 2049'. Call Me By Your Name-skuespilleren Timothée Chalamet skal overtage rollen som Atreides fra Kyle MacLachlan, som tidligere portrætterede hertugsønnen i 1984. Modsat Lynch vil Villeneuve få frie tøjler til at føre sin version af Herberts 400 sider til live med en to-delt filmatisering."
                    },
                    PosterImage = "https://www.nfbio.dk/sites/nfbio.dk/files/styles/movie_poster/public/movie-posters/HO00002208_103583.jpg?itok=mfGxaaOu",
                    Categories = new FilmCategory[]
                    {
                        FilmCategory.Adventure,
                        FilmCategory.Drama,
                        FilmCategory.ScienceFiction
                    },
                    Director = "Denis Villeneuve",
                    FilmType = FilmType.TwoD,
                    PremiereDate = new DateTime(2021,9,16),
                    PlayTime = new TimeSpan(2,35,0),
                    Stars = new string[]
                    {
                        "Timothée Chalamet",
                        "Rebecca Ferguson",
                        "Jason Momoa",
                        "Zendaya",
                        "Josh Brolin",
                        "Oscar Isaac",
                        "Javier Bardem",
                        "Dave Bautista",
                        "Stellan Skarsgård",
                        "Charlotte Rampling"
                    },
                    Rating = 8.5
                };
            }
        }
    }
}
