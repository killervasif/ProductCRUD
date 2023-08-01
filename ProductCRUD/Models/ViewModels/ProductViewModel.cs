﻿using System.ComponentModel.DataAnnotations;

namespace ProductCRUD.Models.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Count { get; set; }

        public string? ImageLink { get; set; } = null;
    }
}
