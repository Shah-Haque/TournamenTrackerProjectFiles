using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// represents the unique ID of the prize
        /// </summary>
        public int PrizesID { get; set; }


        /// <summary>
        /// represents team's place in rank  
        /// </summary>
        [Display(Name = "Place Number")]
        [Range(1,100)]
        [Required]
        public int placeNumber { get; set;}

        /// <summary>
        /// represents place number rank e.g. 1 or FirstPlace
        /// </summary>
        [Display(Name = "Place Name")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string PlaceName { get; set; }

        /// <summary>
        /// the prize amount the team earned
        /// </summary>
        [Display(Name = "Prize Amount")]
        [DataType(DataType.Currency)]   
        public decimal prizeAmount { get; set; }

        /// <summary>
        /// the percentage calculated would be taken from the prizeamount
        /// </summary>
        [Display(Name = "Prize Percentage")]
        public double prizePercentage  { get; set; }


        public PrizeModel()
        {}

        public PrizeModel(string placeName, string PlaceNumber, string PrizeAmount, string PrizePercentage )
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(PlaceNumber, out placeNumberValue);
            placeNumber= placeNumberValue;

            decimal PrizeAmountValue = 0;
            decimal.TryParse(PrizeAmount, out PrizeAmountValue);
            prizeAmount = PrizeAmountValue;

            double PrizePercentageValue = 0;
            double.TryParse(PrizePercentage, out PrizePercentageValue);
            prizePercentage = PrizePercentageValue;
        }
        
    }
}