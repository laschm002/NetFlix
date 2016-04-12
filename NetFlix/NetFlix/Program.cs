using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue cat = new Catalogue();
            Genre all = new Genre("all");
            Genre western = new Genre("Western");
            Movie lostboys = new Movie("Lost Boys",5, 120);
            Show office = new Show("The Office", 5);
            Episode pilot = new Episode("pilot", 5);
            Movie batman = new Movie("Batman", 5, 123);
            Title title = new Title();
            View view = new View();
            view.enterMovieOrShow();
            //office.createListofEpisodes(pilot);

            western.addTitle(office);
            
            //cat.addGenres();
            //cat.addtoGenreList(western);
            //western.addTitle(lostboys);
            //western.GetEnumerator();
            Console.WriteLine(western);

            Console.ReadKey();
        }
    }
}
