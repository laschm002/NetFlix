using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    public class Genre : IEnumerable
     
    {
        List<Title> titles;
        string genreType;
        public Genre(string GenreType) 
        {
            genreType = GenreType;
            titles = new List<Title>();
        }

        public List<Title> addTitle (Title title)
        {
            titles.Add(title);
           
            foreach(Title name in titles)
                Console.WriteLine(name);
            return titles;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < titles.Count; i++)
            {
                Console.WriteLine(titles[i]);
                yield return titles[i];

            }

        }
        public static Object operator +(Genre a, Genre b)
        {
            Genre newGenre = new Genre("");
            newGenre.genreType = a.genreType + b.genreType;
            return newGenre;
        }
        public static Object operator +(Genre genre, Title title)
        {
            Genre newGenre = new Genre("");
            newGenre.genreType = genre.genreType + title.name;
            return newGenre;
        }

    }


}

