using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    public class Catalogue
    {
        public List<Genre> genres;

       // Show lost = new Show("Lost", 2);
        //Show dexter = new Show("Dexter", 4);
        //Movie fightclub = new Movie("Fight Club ", 135);
        //Movie up = new Movie("Up", 5);
        //Movie dazedAndConfused = new Movie("Dazed and Confused", 5);
        //Show modernFamily = new Show("Modern Family ", 4);
        //Movie shutterIsland = new Movie("Shutter Island", 5);
        //Movie traffic = new Movie("Traffic", 4);
        //Show office = new Show("The Office", 5);


        public Catalogue()
        {
            genres = new List<Genre>();
            
        }

        public List<Genre> addtoGenreList(Genre genre)
        {
            genres.Add(genre);
           
            return genres;
        }

        public void addTitlesToGenre (Genre genre, Title title)
        {
            genre.addTitle(title);         
           
        }
        public List<Genre> addGenres()
        {
            genres.Add(new Genre("Action"));
            genres.Add(new Genre("All"));
            genres.Add(new Genre ("Comedy"));
            genres.Add(new Genre ("Romance"));

            //foreach(Genre type in genres)
                  
            return genres;
          
        }
    }
}
