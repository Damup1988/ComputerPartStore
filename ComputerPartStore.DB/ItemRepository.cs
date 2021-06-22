using System;
using System.Collections.Generic;
using ComputerPartStore.Domain;

namespace ComputerPartStore.DB
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemContext _context;

        public ItemRepository(ItemContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void AddNewItem(Item newItem)
        {
            _context.Items.Add(newItem);
        }

        public void UpdateItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}