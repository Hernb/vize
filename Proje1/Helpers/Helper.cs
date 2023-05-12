using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Karayip Korsanları",
                    category = Category.fantastik,
                    minute = "3 Saat 10 Dakika",
                    price = 75,
                    picturePath = basePath + "/karayip.jpg"
                },
                   new Movie()
                {
                    movieName = "Redlights",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 35 Dakika",
                    price = 105,
                    picturePath = basePath + "/redlights.jpg"
                },
                new Movie()
                {
                    movieName = "Esaretin Bedeli",
                    category = Category.gerilim,
                    minute = "2 Saat 59 Dakika",
                    price = 80,
                    picturePath = basePath + "/shawshank.jpg"
                },
                new Movie()
                {
                    movieName = "Snowpiercer",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 15 Dakika",
                    price = 75,
                    picturePath = basePath + "/snowpiercer.jpg"
                },
                new Movie()
                {
                    movieName = "Thor",
                    category = Category.komedi,
                    minute = "3 Saat",
                    price = 78,
                    picturePath = basePath + "/thor.jpg"
                },

             new Movie()
                {
                    movieName = "Twilight",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 45 Dakika",
                    price = 72,
                    picturePath = basePath + "/twilight.jpg"
                },


            };
        }
    }
}
