using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Campeonato
{
    class Match
    {
        public Clube homeTeam;
        public Clube awayTeam;

        public int goalsHome;
        public int goalsAway;
        public int weekMatch;

        public Match(Clube homeTeam, Clube awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }

        public Match(Clube homeTeam, Clube awayTeam, int weekMatch)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.weekMatch = weekMatch;
        }
    }
}
