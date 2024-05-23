using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}