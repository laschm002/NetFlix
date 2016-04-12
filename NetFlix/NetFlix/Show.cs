using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    class Show : Title
    {
        List<Episode> episodes;

        int rating;
        public Show(string Name, int Rating) : base(Name,Rating)
        {
            name = Name;
            episodes = new List<Episode>();
            rating = rating / episodes.Count();

        }

        public List<Episode> createListofEpisodes(Episode episode)
        {
            episodes.Add(episode);
            

            return episodes;
        
        }
        public override string ToString()
        {
            return "Show: " + name + " " + rating;
        }
    }
}

