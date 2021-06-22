using System;
using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartStore.DB
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid Id);
        void AddNewItem(Item newItem);
        void UpdateItem(Guid id);
        void DeleteItem(Guid id);
    }
}