using System;
using System.Collections.Generic;
using ComputerPartStore.Domain;

namespace ComputerPartStore.BusinessLogic
{
    public class MyItemClient : IItemClient
    {
        public IEnumerable<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItemByName(string itemName)
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void AddNewItem(Item newItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item existingItem, string itemPropertyName)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}