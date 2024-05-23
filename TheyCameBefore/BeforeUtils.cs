using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : struct, IComparable<T>
        {
            List<T> newItems = new List<T>();
            foreach (T i in items)
            {
                if (i.CompareTo(item) < 0)
                {
                    newItems.Add(i);
                }
            }
            return newItems;
        }
    }
}