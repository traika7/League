using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Campeonato
{
    class Championship
    {
        string year;
        List<Match> weekMatches = new List<Match>();
        List<Clube> Clubes = new List<Clube>();

        public List<Match> GetGamesFromMatchWeek(int MatchWeek)
        {
            List<Match> weekMatch = new List<Match>();


            for (int i = 0; i < weekMatches.Count; i++)
            {
                if (weekMatches[i].weekMatch == MatchWeek)
                {
                    weekMatch.Add(weekMatches[i]);
                }
            }
            return weekMatch;
        }

        public void SetTeams(List<Clube> Clubes)
        {
            this.Clubes = Clubes;
        }

        public void GenerateAllMatchWeek()
        {
            int matchWeekNumber = 1;
            var rand = new Random();
            int totalCiclo = Clubes.Count / 2;

            for (int i = 0; i < 2; i++)
            {
                List<Clube> potClubes = Clubes.ToList();

                for (int j = 0; j < totalCiclo; j++)
                {
                    int randClube = rand.Next(0, potClubes.Count);
                    Clube homeTeam = potClubes[randClube];
                    potClubes.Remove(homeTeam);

                    randClube = rand.Next(0, potClubes.Count);
                    Clube awayTeam = potClubes[randClube];
                    potClubes.Remove(awayTeam);

                    Match match = new Match(homeTeam, awayTeam, matchWeekNumber);
                    weekMatches.Add(match);
                }
                matchWeekNumber += 1;
            }
        }
    }
}
