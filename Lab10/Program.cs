using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Movie List Application";

            List<Movie> MovieList = Movies();

            //menu of genres

            Console.Write("Enter a genre: ");

            string Choice = Console.ReadLine();

            if (Choice == "Superhero")
            {
                foreach (Movie item in MovieList)
                {

                }
            }
            else if (Choice == "Disney")
            {

            }
            else if (Choice == "Crime")
            {

            }
        }

        private static List<Movie> Movies()
        {
            return new List<Movie>
            {
                new Movie { Title = "Superman", Category = "Superhero" },
                new Movie { Title = "Batman", Category = "Superhero" },
                new Movie { Title = "Wonderwoman", Category = "Superhero" },
                new Movie { Title = "Thor", Category = "Superhero" },
                new Movie { Title = "Ironman", Category = "Superhero" },
                new Movie { Title = "Inside Out", Category = "Disney" },
                new Movie { Title = "101 Dalmations", Category = "Disney" },
                new Movie { Title = "Up", Category = "Disney" },
                new Movie { Title = "Mulan", Category = "Disney" },
                new Movie { Title = "Toy Story", Category = "Disney" },
                new Movie { Title = "The Godfather", Category = "Crime" },
                new Movie { Title = "Goodfellas", Category = "Crime" },
                new Movie { Title = "City of God", Category = "Crime" },
                new Movie { Title = "Gold", Category = "Crime" },
                new Movie { Title = "Wolf of Wall Street", Category = "Crime" },

            };
        }
    }
}
