using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public abstract class Dynamic<T>
    {



        public abstract void Insert(T addValue, int IndexToInsert);
        public abstract void Add(T addValue);
        public abstract void Remove(int IndexToInser);
        public abstract T Get(int IndexToInsert);
        public T[] Array;



    }
}
