using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public class MatchupModel
   {
        /// <summary>
        /// represents the unique ID for the Matchup
        /// </summary>
        public int MatchupID { get; set; }

        /// <summary>
        /// Represents the  list  of upcominng matches from the MatchupModel
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The ID from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerID { get; set; }

        /// <summary>
        /// Represents which team won
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents which round this match is a part of
        /// </summary>
        public int  MatchupRound { get; set; }

        public string displayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }

                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return output;
            }
        }

           
   }
}