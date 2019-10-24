using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPIdentity.Models;

namespace ASPIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPIdentity.Models.Klub> Klub { get; set; }
        public DbSet<ASPIdentity.Models.Tekme> Tekme { get; set; }
    }
}
