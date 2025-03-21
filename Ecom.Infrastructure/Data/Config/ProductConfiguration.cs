﻿using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config;

class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(f => f.Name).IsRequired();
        builder.Property(f => f.Description).IsRequired();
        builder.Property(f => f.NewPrice).HasColumnType("decimal(18,2)");

        builder.HasData(
                new Product { Id = Guid.Parse("ba9ff159-0008-4b8a-99d6-3a71b3226969"), Name = "test", Description = "test", CategoryId = Guid.Parse("ba9ff159-0008-4b8a-99d6-3a71b3226969"), NewPrice = 12 });
    }
}

