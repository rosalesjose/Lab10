using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Movie List Application";
            //ArrayList MovieList = Movies();

            Movie m1 = new Movie("Batman", "Superhero", 1);
            Movie m2 = new Movie("Superman", "Superhero", 1);
            Movie m3 = new Movie("Wonderwoman", "Superhero", 1);
            Movie m4 = new Movie("Thor", "Superhero", 1);
            Movie m5 = new Movie("Ironman", "Superhero", 1);
            Movie m6 = new Movie("Inside Out", "Superhero", 2);
            Movie m7 = new Movie("101 Dalmations", "Superhero", 2);
            Movie m8 = new Movie("Up", "Superhero", 2);
            Movie m9 = new Movie("Mulan", "Superhero", 2);
            Movie m10 = new Movie("Toy Story", "Superhero", 2);
            Movie m11 = new Movie("The Godfather", "Superhero", 3);
            Movie m12 = new Movie("Goodfellas", "Superhero", 3);
            Movie m13 = new Movie("City of God", "Superhero", 3);
            Movie m14 = new Movie("Gold", "Superhero", 3);
            Movie m15 = new Movie("Wolf of Wall Stree", "Crime", 3);

            //menu of genres

            Console.Write("Enter a genre: ");

            string Choice = Console.ReadLine();

            if (Choice == "Superhero")
            {
                for (int i = 0; i < MovieList.Count; i++)
                {
                    Console.WriteLine(MovieList[i]);
                }
            }

            else if (Choice == "Disney")
            {

            }

            else if (Choice == "Crime")
            {

            }

        }

        

    }
}
