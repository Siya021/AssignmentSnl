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
                this.wins = 0;
                this.loses = 0;
                this.draws = 0;
            }

            public void DisplayTeamInfo()
            {
                Console.WriteLine($"Team Name: {teamName}");
                Console.WriteLine($"Coach Name: {coachName}");
                Console.WriteLine($"Number of Players: {numberOfPlayers}");
                Console.WriteLine($"League: {league}");
                Console.WriteLine($"Wins: {wins}");
                Console.WriteLine($"Loses: {loses}");
                Console.WriteLine($"Draws: {draws}");
                Console.WriteLine($"Points: {CalculatePoints()}");
            }

            public void UpdateWins(int wins)
            {
                this.wins += wins;
            }

            public void UpdateLoses(int loses)
            {
                this.loses += loses;
            }
            public void UpdateDraws(int draws)
            {
                this.draws += draws;
            }
            public int CalculatePoints()
            {
                return (wins * 3) + draws;
            }
        }
}
