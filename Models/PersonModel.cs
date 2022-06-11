using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// represents the unique ID of the person
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// FirstName of TeamMember
        /// </summary>
        /// StringLength will set some requirments of what the field should contain 
        /// whenever the user types in their details
        [Display (Name ="Given Name")]
        [StringLength(100, MinimumLength =2)]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of teamMember
        /// </summary>
        /// This will display the name in the form 
        [Display(Name ="Last Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Emailaddress of team member
        /// </summary>
        [Display(Name = "Email Address")]
        [Required]
        [StringLength (250, MinimumLength = 6)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// TelephoneNumber of team member
        /// </summary>
        [Display(Name ="Phone Number")]
        [StringLength(20, MinimumLength = 10)]
        [Required]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// shows the fullname of the person
        /// </summary>
        public  string FullName
        {
            get 
            {
              return $"{FirstName} {LastName}";
            }
        }

    }
} 
