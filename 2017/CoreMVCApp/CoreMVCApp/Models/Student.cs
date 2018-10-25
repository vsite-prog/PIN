using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        [Display(Name = "Datum rođenja")]
        [DataType(DataType.Date)]
        public DateTime DatRod { get; set; }
        public int Faks { get; set; }
    }
}
