using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ComputerPartStore.Domain
{
    public class Item
    {
        /// <summary>
        /// items properties
        /// </summary>
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable => Quantity > 0;
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Dictionary<string, string> ItemProperties { get; set; }
    }
}