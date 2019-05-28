using Part2Exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2Exam.Data.EntitiesConfiguration
{
    internal class MenuEntititesConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {

            builder.HasOne<Dish>()
                   .WithMany()
                   .HasForeignKey(x => x.DishId)
                   .IsRequired();

        }
    }
}
