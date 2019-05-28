using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel;
using Microsoft.EntityFrameworkCore;

namespace TestExam.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<File> Files { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
    }
}
