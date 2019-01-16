using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCModelApp.Models
{
    public class Projekcija
    {
        // Primarni ključ
        public int Id { get; set; }
        // Strani ključ
        public Film Film { get; set; }
        public int FilmId { get; set; }
        // Strani ključ
        public Kino Kino { get; set; }
        public int KinoId { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Datum projekcije")]
        public DateTime Datum { get; set; }
    }
}
