using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BartenderApp.Models
{
    public class DrinkOrder
    {
        //public string OrderId { get; set; }

        //public int OrderQuantity { get; set; }
        //[Required(ErrorMessage = "Please enter your name")]
        public string CustomerName { get; set; }
        //[Required(ErrorMessage = "Please enter a valid drink name")]
        public string DrinkName { get; set; }
       // [Required(ErrorMessage = "Please enter a valid time, {hh:mm}")]
        public TimeSpan OrderTime { get; set; }
        //public bool Status { get; set; }
    }
}
