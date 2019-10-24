using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIdentity.Models
{
    public class Klub
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Naš klub")]
        public string Ime { get; set; }
        [Required]
        public string Sport { get; set; }
    }
}
