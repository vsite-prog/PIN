using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreModel.Models
{
    public class Student
    {

        public int Id { get; set; }

        [ MaxLength(30), MinLength(3)]
        public string Ime { get; set; }

        [Required]
        public string Oib { get; set; }

        [Display(Name ="Datum rođenja")]
        [DataType(DataType.Date)]
        public DateTime DatRod { get; set; }
    }
}
