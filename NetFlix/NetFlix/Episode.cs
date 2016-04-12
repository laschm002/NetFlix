using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    public class Episode
    {
        string episodeName;
        int episodeRating;
        public Episode(string EpisdoeName, int EpisodeRating )
        {
            episodeName = EpisdoeName;
            episodeRating = EpisodeRating;
        }
    }
}
