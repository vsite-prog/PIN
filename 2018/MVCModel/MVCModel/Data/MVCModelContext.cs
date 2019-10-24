using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCModel.Models
{
    public class MVCModelContext : DbContext
    {
        public MVCModelContext (DbContextOptions<MVCModelContext> options)
            : base(options)
        {
        }

        public DbSet<MVCModel.Models.Student> Student { get; set; }
    }
}
