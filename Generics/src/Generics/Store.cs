using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IHasId
    {
        int Id { get; }

    }
    public class Store<T> where T : IHasId
    {
        private Dictionary<int, T> items = new Dictionary<int, T>();

        public void Add(T item)
        {
            if(items.ContainsKey(item.Id))
            {
                throw new ArgumentException($"An item with Id {item.Id} already exists.");
            }
            items[item.Id] = item;
        }

        public T? GetById(int id)
        {
            if (items.TryGetValue(id, out T? item))
            {
                return item;
            }
            
            return default;
        }

        public void Remove(int id)
        {
            items.Remove(id);
        }

        public IReadOnlyDictionary<int, T> GetAll()
        {
            return items;
        }
    }
}
