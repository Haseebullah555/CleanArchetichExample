using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<StudentModel>
    {
        public void Configure(EntityTypeBuilder<StudentModel> builder)
        {
            builder.HasData(new StudentModel
            {
                Id = 1,
                FirstName = "Ahmad",
                LastName = "Rahmani",
                Email = "ahmad.rahmani@gmail.com",
                Grade = "A"
            });
        }
    }
}
