using System;
using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ComputerPartStore.BusinessLogic
{
    public interface IItemClient
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(Guid Id);
        void AddNewItem(Item newItem);
        void UpdateItem(Guid id);
        void DeleteItem(Guid id);
    }
}