
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RpsGame_NoDb
{
    public class Match
    {
        // private Guid matchId = Guid.NewGuid();
        [Key]
        public Guid MatchId { get; set; } = Guid.NewGuid();

        public Player Player1 { get; set; } // always the computer
        public Player Player2 { get; set; } // always the user.

        public List<Round> Rounds = new List<Round>();

        public int p1RoundWins { get; set; } // ho many rounds has the player won?
        public int p2RoundWins { get; set; }
        public int ties { get; set; }


        /// <summary>
        /// This is the description of the method called RoundWinner
        /// This methodtakes an optional Player object and increments the numnber of round wins for that player.
        /// no arguments means a tie.
        /// </summary>
        /// <param name="p"></param>
        public void RoundWinner(Player p = null)
        {
            if (p == null)
            {
                ties++;
            }
            else if (p.PlayerId == Player1.PlayerId)
            {
                p1RoundWins++;
            }
            else if (p.PlayerId == Player2.PlayerId)
            {
                p2RoundWins++;
            }
        }

        public Player MatchWinner()
        {
            if (p1RoundWins == 2)
            {
                return Player1;
            }
            else if (p2RoundWins == 2)
            {
                return Player2;
            }
            else
            {
                return null;
            }
        }
    }
}