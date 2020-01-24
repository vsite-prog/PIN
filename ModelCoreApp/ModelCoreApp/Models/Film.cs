using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelCoreApp.Models
{
    public class Film
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Naziv { get; set; }

        [MaxLength(30)]
        public string Drzava { get; set; }

        [Display(Name = "Datum izdavanja")]
        [DataType(DataType.Date), Required, DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]
        public DateTime DatIzd { get; set; }

        [Display(Name ="Žanr")]
        public Zanr Zanr { get; set; }
        public int ZanrId { get; set; }

        [DataType(DataType.Text)]
        public string Opis { get; set; }
    }
}
