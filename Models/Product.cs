using System;
using System.Collections.Generic;

namespace AzreCICDDemo.Models
{
    public partial class Product
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public byte? CategoryId { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }

        public virtual Category? Category { get; set; }
    }
}
