using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore2.Models
{
    public class Pas
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "IMe mora biti kraće od 20 znakova.")]
        public string Ime { get; set; }
        [Display(Name ="Datum rođenja")]
        [DataType(DataType.Date)]
        public DateTime DatRod { get; set; }
        public int VrstaId { get; set; }
        public Vrsta Vrsta { get; set; }
    }
}
