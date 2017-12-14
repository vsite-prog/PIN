using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCApp.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext (DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMVCApp.Models.Student> Student { get; set; }
    }
}
