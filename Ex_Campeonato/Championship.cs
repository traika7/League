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

        public int GetNumberOfGameWeeks() =>  (Clubes.Count - 1)*2;

        public void SetTeams(List<Clube> Clubes)
        {
            this.Clubes = Clubes;
        }

        public void GenerateAllMatchWeek()
        {
            int matchWeekNumber = 1;
            int halfLeague = Clubes.Count / 2;
            List<Clube> potClubes = Clubes.ToList();
            for (int i = 0; i < Clubes.Count - 1; i++)
            {
                for (int j = 0; j < halfLeague; j++)
                {

                    Match match = new Match(potClubes[j], potClubes[Clubes.Count-1 - j], matchWeekNumber);
                    weekMatches.Add(match);
                }
                potClubes = RotatePot(potClubes);
                matchWeekNumber += 1;
            }

            //Segunda metade do campeonato
            int numberOfMatchesSoFar = weekMatches.Count;
            for (int i = 0; i < numberOfMatchesSoFar ; i++)
            {   
                Match match = new Match(weekMatches[i].awayTeam, weekMatches[i].homeTeam, weekMatches[i].weekMatch + (GetNumberOfGameWeeks() / 2));
                weekMatches.Add(match);
            }
        }

        private List<Clube> RotatePot(List<Clube> Clubes)
        {
            List<Clube> rotatedList = new List<Clube>();
            rotatedList.Add(Clubes[0]);
            for (int i = 0; i < Clubes.Count  - 1; i++)
            {
                if (i == 0)
                {
                    rotatedList.Add(Clubes[Clubes.Count - 1]);
                    continue;
                }

                    rotatedList.Add(Clubes[i]);
            }
            return rotatedList;
        }
    }
}
