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
        /// <returns> array of items</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return _itemClient.GetAllItems();
        }
    }
}