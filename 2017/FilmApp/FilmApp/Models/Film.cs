using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmApp.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15, ErrorMessage ="Maks 15 znakova!")]
        public string Naziv { get; set; }
        [Range(1900, 2020, ErrorMessage ="Kriva godina!")]
        public int Godina { get; set; }
        public int ZanrId { get; set; }
        [Display(Name ="Žanr")]
        public Zanr Zanr { get; set; }
    }
}
