using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreModel.Models;

namespace ASPNETCoreModel.Data
{
    public class BazaKontekst : DbContext
    {
        public BazaKontekst (DbContextOptions<BazaKontekst> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCoreModel.Models.Film> Film { get; set; }
    }
}
