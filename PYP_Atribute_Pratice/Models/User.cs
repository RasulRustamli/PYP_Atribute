using PYP_Atribute_Pratice.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Atribute_Pratice.Models
{
    public class User
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [ValidEmail]
        public string Email { get; set; }

        [ValidPassword]
        public string Password { get; set; }
    }
}
