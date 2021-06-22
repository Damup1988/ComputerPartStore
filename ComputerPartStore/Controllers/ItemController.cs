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
        private readonly IItemClient _itemClient;
        
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
        /// CREATE
        /// </summary>
        /// <param name="newItem"></param>
        [HttpPost]
        public ActionResult<Item> InsertItem(Item newItem)
        {
            _itemClient.AddNewItem(newItem);
            return Ok(newItem);
        }

        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="item"></param>
        [HttpPut("{id}")]
        public void UpdateItem(Guid id)
        {
            _itemClient.UpdateItem(id);
        }
        
        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteItemById(Guid id)
        {
            _itemClient.DeleteItem(id);
        }
    }
}