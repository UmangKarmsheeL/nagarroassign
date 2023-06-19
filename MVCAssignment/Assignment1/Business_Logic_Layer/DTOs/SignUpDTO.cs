using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent1.DTOs
{
    public class SignUpDTO
    {
        [Required(ErrorMessage = "Please Enter the First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        [Display(Name ="Email address")]
        [EmailAddress(ErrorMessage ="Please Enter a Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter a strong password")]
        [Compare("ConfirmPassword",ErrorMessage ="Password does not match")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage ="Please confirm your password")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
