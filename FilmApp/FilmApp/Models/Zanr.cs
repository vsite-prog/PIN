using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmApp.Models
{
    public class Zanr
    {
        public int Id { get; set; }
        [Required, MaxLength(15,ErrorMessage ="15 znakova!")]
        public string Naziv { get; set; }
    }
}
