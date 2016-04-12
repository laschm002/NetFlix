using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    class Movie : Title
    {
        public int duration;
        public int rating;


        public Movie(string Name, int Rating, int Duration) : base(Name, Rating)
        {
            this.rating = Rating;
            duration = Duration;
        }

        public override string ToString()
        {
            return "Movie: " + name + " " + duration;
        }


    }
}
