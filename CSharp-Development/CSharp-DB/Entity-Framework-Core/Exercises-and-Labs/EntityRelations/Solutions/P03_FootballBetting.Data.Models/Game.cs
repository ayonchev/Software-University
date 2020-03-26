using System;
using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public GameResult Result { get; set; }
        public DateTime DateTime { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public decimal HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public decimal AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }

        public decimal DrawBetRate { get; set; }

        public ICollection<Bet> Bets { get; set; } = new List<Bet>();
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new List<PlayerStatistic>();
    }
}