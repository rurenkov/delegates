using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class DynamicQueue<T>
    {
        
        DynamicArray<T> dynamicArray = new DynamicArray<T>();

        public void Equeue(T put)
        {
            dynamicArray.Add(put);
        }
        public void Dequeue(int IndexToInsert)

        {
            dynamicArray.Get(IndexToInsert);
            dynamicArray.Remove(IndexToInsert);
        }


      

    }
}
