using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The ID for the Teams
        /// </summary>
        public int TeamID { get; set; }
        /// <summary>
        /// name of Team
        /// </summary>
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        /// <summary>
        /// List of teammembers
        /// </summary>
        [Display(Name = "List of Team Members")]
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
