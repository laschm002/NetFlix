using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    public class Title
    {
        public string name;
        private int? rating;
        public Title(string Name, int Rating)
        {
            name = Name;
            rating = Rating;
        }

        public Title()
        {
            name = null;
            rating = null;

        }

        public static Object operator +(Title a, Title b)
        {
            Genre newGenre = new Genre(a.name + b.name);
            return newGenre;
        }

    }
}
