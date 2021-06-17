using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;

namespace ComputerPartStore.BusinessLogic
{
    public interface IItemClient
    {
        IEnumerable<Item> GetAllItems();
    }
}