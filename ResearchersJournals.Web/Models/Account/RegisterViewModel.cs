using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(50 , ErrorMessage = "Maximum {1} characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Maximum {1} characters")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage= "It must be a valid email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        
    }
}
