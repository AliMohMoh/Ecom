using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasData(new Photo { Id = Guid.Parse("ba9ff159-0008-4b8a-99d6-3a71b3226969"), ImageName = "test", ProductId = Guid.Parse("ba9ff159-0008-4b8a-99d6-3a71b3226969") });
        }
    }
}
