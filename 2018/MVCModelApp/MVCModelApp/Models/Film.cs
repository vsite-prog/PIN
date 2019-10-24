using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCModelApp.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Naziv { get; set; }
        public int Godina { get; set; }
    }
}
