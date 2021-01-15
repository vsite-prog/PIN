using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Models
{
    public class Ispit
    {
        public int Id { get; set; }
        public string Predmet { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
    }
}
