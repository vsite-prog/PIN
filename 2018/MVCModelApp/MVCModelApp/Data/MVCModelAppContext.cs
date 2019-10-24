using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCModelApp.Models;

namespace MVCModelApp.Models
{
    public class MVCModelAppContext : DbContext
    {
        public MVCModelAppContext (DbContextOptions<MVCModelAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCModelApp.Models.Film> Film { get; set; }

        public DbSet<MVCModelApp.Models.Kino> Kino { get; set; }

        public DbSet<MVCModelApp.Models.Projekcija> Projekcija { get; set; }
    }
}
