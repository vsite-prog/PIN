using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelCoreApp.Models
{
    public class Zanr
    {
        public int Id { get; set; }
        
        [MaxLength(30), Required]
        public string Naziv { get; set; }
        [DataType(DataType.Text)]
        public string Opis { get; set; }
    }
}
