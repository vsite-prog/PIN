using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelApp.Models
{
    public class Vrsta
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Naziv { get; set; }
    }
}
