using System;
using System.ComponentModel.DataAnnotations;

namespace CarDealerApp.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string? Make { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        [Range(1900, 2025)]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}
