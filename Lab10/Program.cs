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
        static bool RunProgram = true;
        static void Main(string[] args)
        {

            Console.Title = "Movie List Application";
            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine("BLOCKBUSTER GENRE\n\n[1]Superhero     [2]Disney     [3]Crime");

                List<Movie> MovieList = new List<Movie>
            {
                new Movie("Batman", "Superhero", 1),
                new Movie("Superman", "Superhero", 1),
                new Movie("Wonderwoman", "Superhero", 1),
                new Movie("Thor", "Superhero", 1),
                new Movie("Ironman", "Superhero", 1),
                new Movie("Inside Out", "Disney", 2),
                new Movie("101 Dalmations", "Disney", 2),
                new Movie("Up", "Disney", 2),
                new Movie("Mulan", "Disney", 2),
                new Movie("Toy Story", "Disney", 2),
                new Movie("The Godfather", "Crime", 3),
                new Movie("Goodfellas", "Crime", 3),
                new Movie("City of God", "Crie", 3),
                new Movie("Gold", "Crime", 3),
                new Movie("Wolf of Wall Street", "Crime", 3)
            };

                int Choice = GetChoice();
                GetCategory(MovieList, Choice);
                
                Console.WriteLine("\nEnter the 'Y' key to choose a different movie category. \nOr enter 'N' to quit.");
                bool MakeDecision = true;

                while (MakeDecision)
                {
                    try
                    {
                        bool UserDecision = Decision();
                        RunProgram = UserDecision;
                        MakeDecision = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter the 'Y' key if you want to run the program again.");
                        Console.WriteLine("Enter 'N' if you want to exit the program.");
                    }
                }

            }
        }

        private static void GetCategory(List<Movie> MovieList, int Choice)
        {
            if (Choice == 1)
            {

                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Id == Choice)
                    {
                        Console.WriteLine(MovieList[i].Title);
                    }
                }
            }

            else if (Choice == 2)
            {
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Id == Choice)
                    {
                        Console.WriteLine(MovieList[i].Title);
                    }
                }
            }

            else if (Choice == 3)
            {
                for (int i = 0; i < MovieList.Count; i++)
                {
                    if (MovieList[i].Id == Choice)
                    {
                        Console.WriteLine(MovieList[i].Title);
                    }
                }
            }
        }

        private static int GetChoice()
        {
            Console.Write("\nEnter the number of the genre you want: ");
            try
            {
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1 || Choice == 2 || Choice == 3)
                    return Choice;
                else
                    return GetChoice();
            }
            catch (Exception)
            {
                return GetChoice();
            }
        }

        public static bool Decision()
        {
           
            char UserDecision = char.Parse(Console.ReadLine());
            if (UserDecision == 'y' || UserDecision == 'Y')
            {
                Console.Clear();
                return RunProgram = true;
            }
            else if (UserDecision == 'n' || UserDecision == 'N')
            {
                return RunProgram = false;
            }
            else
            {
                return Decision();
            }
        }
    }
}
