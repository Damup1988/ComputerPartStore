using System;
using System.Collections.Generic;
using ComputerPartStore.DB;
using ComputerPartStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ComputerPartStore.BusinessLogic
{
    public class MyItemClient : IItemClient
    {
        private readonly IItemRepository _itemRepository;

        public MyItemClient(IItemRepository repository)
        {
            _itemRepository = repository;
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
            _itemRepository.AddNewItem(newItem);
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