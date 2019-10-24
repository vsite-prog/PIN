using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCModelApp.Models
{
    public class Kino
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Naziv { get; set; }
        public string Grad { get; set; }
    }
}
