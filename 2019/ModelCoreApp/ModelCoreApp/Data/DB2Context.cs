using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelCoreApp.Models;

namespace ModelCoreApp.Models
{
    public class DB2Context : DbContext
    {
        public DB2Context (DbContextOptions<DB2Context> options)
            : base(options)
        {
        }

        public DbSet<ModelCoreApp.Models.Film> Film { get; set; }

        public DbSet<ModelCoreApp.Models.Zanr> Zanr { get; set; }
    }
}
