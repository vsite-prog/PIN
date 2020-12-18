using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreModel.Models
{
    public class Film
    {
        public int Id { get; set;}

        public string Naziv { get; set; }

        public string Komentar { get; set; }

        public DateTime DatIzd { get; set; }

    }
}
