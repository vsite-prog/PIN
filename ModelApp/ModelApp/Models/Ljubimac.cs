using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelApp.Models
{
    public class Ljubimac
    {
        public int Id { get; set; }

        [Required, MaxLength(40)]
        public string Ime { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum rođenja"), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DatRod { get; set; }

        [MaxLength(400)]
        public string Opis { get; set; }

        [Display(Name ="Živ vrsta")]
        public Vrsta Vrsta { get; set; }
        public int VrstaId { get; set; }
    }
}
