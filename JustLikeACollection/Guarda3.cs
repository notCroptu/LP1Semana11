using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T one;
        private T two;
        private T three;
        public Guarda3()
        {
            one = default(T);
            two = default(T);
            three = default(T);
        }
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return one;
                case 1:
                    return two;
                case 2:
                    return three;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        public void SetItem(int i , T item)
        {
            switch (i)
            {
                case 0:
                    one = item;
                    break;
                case 1:
                    two = item;
                    break;
                case 2:
                    three = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(one, default(T)))
            {
                one = item;
            }
            else if (EqualityComparer<T>.Default.Equals(two, default(T)))
            {
                two = item;
            }
            else if (EqualityComparer<T>.Default.Equals(three, default(T)))
            {
                three = item;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            yield return one;
            yield return two;
            yield return three;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}