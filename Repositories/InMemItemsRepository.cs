using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;

namespace Catalog.Repositories
{
   
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new(){
            new Item {Id = Guid.NewGuid(), Name = "Joao Victor Preissler", CPF = "15509174714"},
            new Item {Id = Guid.NewGuid(), Name = "Fernando Carlos Alberto", CPF = "15509174714"},
            new Item {Id = Guid.NewGuid(), Name = "Gisele Preissler Marcolino Alberto", CPF = "15509174714"},
            new Item {Id = Guid.NewGuid(), Name = "Yanasha Magalhães de Souza", CPF = "15509174714"}
        };

        public IEnumerable<Item> GetItems(){
            return items;
        }

        public Item GetItem(Guid id){
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }
        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
        }
    }
}