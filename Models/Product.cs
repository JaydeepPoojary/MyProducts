using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyProducts.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        [MaxLength(100)]
        public String Brand { get; set; } = "";


        [MaxLength(100)]
        public string Category { get; set; } = "";


        [Precision(16,2)]
        public decimal Price { get; set; }

        public string Description { get; set; } = "";


        [MaxLength(100)]
        public String ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}
