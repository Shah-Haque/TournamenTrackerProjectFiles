using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// The tournament model for the tournament Tracker
    /// </summary>
    public class TournamentModel
    {

        /// <summary>
        /// This events notfies users that the tournament is completed
        /// </summary>
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// Unique ID of Tournament
        /// </summary>
        public int TournamentID { get; set;}

        /// <summary>
        /// Name of Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// the entry fee for users to watch the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// the teams entered in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// the list of available prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The Matchups per Round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        /// <summary>
        /// This completes the tournament
        /// </summary>
        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }

    }
}