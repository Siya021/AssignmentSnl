using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    
       public class FootbalTeam
        {
            private string teamName;
            private string coachName;
            private int numberOfPlayers;
            private LeagueEnum league;
            private int wins;
            private int loses;
            private int draws;

            public FootbalTeam(string teamName, string coachName, int numberOfPlayers, LeagueEnum league, int wins, int loses, int draws)
            {
                this.teamName = teamName;
                this.coachName = coachName;
                this.numberOfPlayers = numberOfPlayers;
                this.league = league;
                this.wins = wins;
                this.loses = loses;
                this.draws = draws;
            }
            public int CalculatePoints()
            {
                return (wins * 3) + draws;
            }
        public string DisplayTeamInfo()
        {
            return $"Team Name: {teamName}\n Coach Name: {coachName}\n Number of Players: {numberOfPlayers}\n League: {league}\n Wins: {wins}\n Losses: {loses}\n Draws: {draws}\n Points: {CalculatePoints()}";
        }

    }
}
