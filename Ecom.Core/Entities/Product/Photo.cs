﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities.Product;

public class Photo : BaseEntity<Guid>
{
    public string ImageName { get; set; } 
    public Guid ProductId { get; set; } 
    //[ForeignKey(nameof(ProductId))]
    //public virtual Product Product { get; set; } = default!;
}
