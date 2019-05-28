using Part2Exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2Exam.Data.EntitiesConfiguration
{
    public class RestarauntEntittiesConfiguration : IEntityTypeConfiguration<Restaraunt>
    {
        public void Configure(EntityTypeBuilder<Restaraunt> builder)
        {

            builder.HasOne<Menu>()
                   .WithMany()
                   .HasForeignKey(x => x.MenuId)
                   .IsRequired();

        }

    }
}
