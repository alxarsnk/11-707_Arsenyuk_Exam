using System;
using System.Collections.Generic;
using System.Text;
using Part2Exam.Data.EntitiesConfiguration;
using Part2Exam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Part2Exam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Restaraunt> Restaraunts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new MenuEntititesConfiguration());
            modelBuilder.ApplyConfiguration(new RestarauntEntittiesConfiguration());
        }



    }
}
