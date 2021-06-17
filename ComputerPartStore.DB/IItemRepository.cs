using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;

namespace ComputerPartStore.DB
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
    }
}