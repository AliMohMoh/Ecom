﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities.Product;

public class Product : BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public virtual List<Photo> Photos { get; set; } = new List<Photo>();
    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; } = default!;
    public Guid CategoryId { get; set; }
}
