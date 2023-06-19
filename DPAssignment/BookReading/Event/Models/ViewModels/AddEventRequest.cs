using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Event.Models.ViewModels
{
    public class AddEventRequest
    {
        [Required(ErrorMessage = "Please enter the title")]
        public string title { get; set; }

        [Required(ErrorMessage = "Please enter the date")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Please enter the location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Please enter the start time")]
        public TimeSpan startTime { get; set; }

        public bool Visible { get; set; }

        [Required(ErrorMessage = "Please enter the duration in hours")]
        [Range(1, 4, ErrorMessage = "Duration must be between 1 and 4 hours")]
        public int durationInHours { get; set; }

        [Required(ErrorMessage = "Please enter the description")]
        public string description { get; set; }

        public string otherDetails { get; set; }

        public string InviteByEmail { get; set; }

       
        public string Organiser { get; set; }
    }
}
