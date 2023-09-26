using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class UserForms
    {
        [Required(ErrorMessage = "Le champ est requis monique, applique toi...")]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [MinLength(5)]
        public string Username { get; set; }

        [Required]
        [RegularExpression("^(?=[\x21-\x7E]*[0-9])(?=[\x21-\x7E]*[A-Z])(?=[\x21-\x7E]*[a-z])(?=[\x21-\x7E]*[\x21-\x2F|\x3A-\x40|\x5B-\x60|\x7B-\x7E])[\x21-\x7E]{6,}$")]
        public string Password { get; set; }
    }
}
