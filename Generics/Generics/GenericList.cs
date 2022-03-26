using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T t)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
