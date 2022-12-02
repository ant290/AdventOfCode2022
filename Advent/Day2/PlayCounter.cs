using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class PlayCounter
    {
        public List<PlayModel> Plays;
        public PlayCounter(IEnumerable<string> data)
        {
            Plays = new List<PlayModel>();
            foreach (string s in data)
            {
                Plays.Add(new PlayModel(s[0], s[2]));
            }
        }

        public int MakePlays()
        {
            return Plays.Sum(x => x.MyScore);
        }
    }
}
