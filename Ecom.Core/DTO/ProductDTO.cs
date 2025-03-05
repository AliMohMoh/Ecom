using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.DTO
{
    public record ProductResDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public virtual List<PhotoDTO> Photos { get; set; }
        public string CategoryName { get; set; }

    }
    public record PhotoDTO
    {
        public string ImageName { get; set; }
        public Guid ProductId { get; set; }
    }
    public record ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public Guid CategoryId { get; set; }
        public IFormFileCollection Photo { get; set; }
    }
    public record AddProductDTO : ProductDTO
    {
        public Guid Id { get; init; } = Guid.NewGuid();
    }
    public record UpdateProductDTO : ProductDTO
    {
        public Guid Id { get; set; }
    }
}
