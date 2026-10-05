using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>( this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber <= 0)
            {
                throw new ArgumentException("Page number must be greater than 0.");
            }

            if (pageSize <= 0)
            {
                throw new ArgumentException("Page size must be greater than 0.");
            }
            int skip = (pageNumber - 1) * pageSize;
            foreach (var item in source)
            {
                if (skip > 0)
                {
                    skip--;
                    continue;
                }
                if (pageSize <= 0)
                {
                    break;
                }
                yield return item;
                pageSize--;
            }


        }
        public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
        {
            foreach(var item in source)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }

        public static IReadOnlyDictionary<int,T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
        {
            var dict = new Dictionary<int, T>();
            foreach (var item in source)
            {
                dict[item.Id] = item;
            }
            return dict;
        }
    }
}
