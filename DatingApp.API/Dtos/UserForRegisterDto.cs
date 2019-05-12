using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public String Username { get; set; }
        [Required]
        [StringLength(12,MinimumLength =6,ErrorMessage ="Please enter a valid password between 8 and 12")]
        public String Password { get; set; }
    }
}
