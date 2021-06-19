using System.Collections;
using System.Collections.Generic;
using ComputerPartStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartStore.DB
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
    }
}