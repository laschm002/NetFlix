using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    public class View
    {
        Catalogue cat = new Catalogue();
        public View()
        {

        }

        public string AddTitle()
        {
            Console.WriteLine("Enter the name of the title you want to add to the database");
            string title = Console.ReadLine();
            return title;
        }

        public int enterRating()
        {
            Console.WriteLine("Enter the rating of the program");
            int rating = Convert.ToInt32(Console.ReadLine());
            return rating;

        }

        public int enterDuration()
        {
            Console.WriteLine("What is the duration of the film?");
            int duration =Convert.ToInt32(Console.ReadLine());
            return duration;
        }
        public int enterMovieOrShow()
        {
            Console.WriteLine("Is your title a movie or a show");
            Console.WriteLine("Press 1 if your title is a movie");
            Console.WriteLine("Press 2 if your title is a show");
            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 1)
            {
                Movie movie = new Movie(AddTitle(), enterRating(), enterDuration());

                Console.WriteLine(movie.name);
                Console.WriteLine(movie.rating);
                Console.WriteLine(movie.duration);

            }
           
            else if (selection == 2)
            {
                Show show = new Show(AddTitle(), enterRating());
            }

            else
            {
                Console.WriteLine("You can only enter 1 or 2");
                enterMovieOrShow();
            }
            
            return selection;

        }


    }
    }

