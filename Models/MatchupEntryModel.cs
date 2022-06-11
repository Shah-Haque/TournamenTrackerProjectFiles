using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
  public class MatchupEntryModel
    {   
        
      /// <summary>
        /// represents the unique ID for the MatchupEntry
        /// </summary>
      public int MatchupEntryID { get; set; }

      /// <summary>
        /// The unique identifier for the team.
        /// </summary>
      public int TeamCompetingID { get; set; }

      /// <summary>
        /// Represents one team in the matchup
        /// </summary>
      public TeamModel TeamCompeting { get; set;}

      /// <summary>
        /// reprrsents the score for this partiuclar team
        /// </summary>
      public double Score { get; set; }

      /// <summary>
        /// The unique identifier for the parent matchup (team).
        /// </summary>
      public int ParentMatchupID { get; set; }

      /// <summary>
        /// represents the matchup that this team came
        /// from as the winner.
        /// </summary>
       public MatchupModel ParentMatchup { get; set;}
  } 
}
