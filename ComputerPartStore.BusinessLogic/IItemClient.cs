using System;
using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;

namespace ComputerPartStore.BusinessLogic
{
    public interface IItemClient
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemByName(string itemName);
        Item GetItemById(Guid Id);
        void AddNewItem(Item newItem);
        void UpdateItem(Item existingItem);
        void DeleteItem(Item itemToRemove);
    }
}