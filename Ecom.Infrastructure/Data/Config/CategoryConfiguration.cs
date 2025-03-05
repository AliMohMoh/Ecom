using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(f=>f.Name).IsRequired().HasMaxLength(30);
            builder.Property(f => f.Id).IsRequired();

            builder.HasData(
               new Category { Id = Guid.Parse("ba9ff159-0008-4b8a-99d6-3a71b3226969"), Name = "test", Description = "test" }
               );
        }
    }
}
