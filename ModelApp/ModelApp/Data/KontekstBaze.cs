using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelApp.Models;

namespace ModelApp.Data
{
    public class KontekstBaze : DbContext
    {
        public KontekstBaze (DbContextOptions<KontekstBaze> options)
            : base(options)
        {
        }

        public DbSet<ModelApp.Models.Ljubimac> Ljubimac { get; set; }

        public DbSet<ModelApp.Models.Vrsta> Vrsta { get; set; }
    }
}
