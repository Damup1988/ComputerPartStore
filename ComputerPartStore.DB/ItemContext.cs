using ComputerPartStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartStore.DB
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
    }
}