using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ComputerPartStore.Domain
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Vendor { get; set; }
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }
        [Required]
        public int Quantity { get; set; }
        public bool IsAvailable => Quantity > 0;
        [Required]
        [MaxLength(100)]
        public string ShortDescription { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Dictionary<string, string> ItemProperties { get; set; }
    }
}