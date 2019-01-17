using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIdentity.Models
{
    public class Tekme
    {
        public int Id { get; set; }
        [Required]
        public int Klub1Id { get; set; }
        public Klub Klub1 { get; set; }

        [Required]
        public int Klub2Id { get; set; }
        public Klub Klub2 { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [Required]
        public decimal Koeficijent { get; set; }

    }
}
