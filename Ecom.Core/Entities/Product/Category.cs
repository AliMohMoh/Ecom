using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities.Product;

public class Category : BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } 
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
