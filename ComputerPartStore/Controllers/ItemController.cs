using System;
using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.BusinessLogic;
using ComputerPartStore.DB;
using ComputerPartStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ComputerPartStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private IItemClient _itemClient;
        
        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns> array of items </returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public IEnumerable<Item> GetAllItems()
        {
            return _itemClient.GetAllItems();
        }

        /// <summary>
        /// get item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetItemById")]
        public Item GetItemById(Guid id)
        {
            return _itemClient.GetItemById(id);
        }

        /// <summary>
        /// get item by name
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns> an item </returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet("{itemName}", Name = "GetItemByName")]
        public Item GetItemByName(string itemName)
        {
            return _itemClient.GetItemByName(itemName);
        }

        /// <summary>
        /// To create new item in our store
        /// </summary>
        /// <param name="newItem"></param>
        [HttpPut]
        public void InsertItem(Item newItem)
        {
            _itemClient.AddNewItem(newItem);
        }

        /// <summary>
        /// to update an item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="itemPropertyName"></param>
        [HttpPatch]
        public void UpdateItem(Item item, string itemPropertyName)
        {
            _itemClient.UpdateItem(item, itemPropertyName);
        }

        /// <summary>
        /// to remove an item by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void DeleteItemById(Guid id)
        {
            _itemClient.DeleteItem(id);
        }
    }
}