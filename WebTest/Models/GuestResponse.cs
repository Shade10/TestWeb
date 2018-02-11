using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać swoj adres e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Proszę podać prawidłowy adres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać swoj numer telefonu")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Proszę określić czy weźmiesz udział")]
        public bool? WillAttend { get; set; }

    }
}