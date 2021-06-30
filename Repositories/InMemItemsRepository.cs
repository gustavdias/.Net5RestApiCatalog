using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;

namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new() //new List<Item>() is the same as new()
        {
            //the instance of the lease should not change after we construct this repository object
            //Target-typed new expression 
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 35, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bonze Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow }
        };

        //how to get, update and delete a item

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(items => items.Id == id).SingleOrDefault();
        }
    }
}