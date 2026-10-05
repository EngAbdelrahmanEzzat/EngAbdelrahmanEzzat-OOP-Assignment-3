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
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T? GetById(int id)
        {
            foreach (var item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }

        public void Remove(int id)
        {
            items.RemoveAll(s => s.Id == id);
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}
