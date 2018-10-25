using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCore2.Models;

namespace MVCCore2.Models
{
    public class PsiContext : DbContext
    {
        public PsiContext (DbContextOptions<PsiContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCore2.Models.Pas> Pas { get; set; }

        public DbSet<MVCCore2.Models.Vrsta> Vrsta { get; set; }
    }
}
