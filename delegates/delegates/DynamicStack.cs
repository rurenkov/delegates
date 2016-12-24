using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class DynamicStack<T>
    {


        DynamicArray<T> dynamicArray = new DynamicArray<T>();
       private T size;
        

        public void Push(T put)
        {

            dynamicArray.Add(put);


        }

       public T Pop()
        {

            int size = dynamicArray.size - 1;
            
            dynamicArray.Remove(dynamicArray.size - 1);
            return this.size;

        }
  

        public T Peek()
        {

            int size = dynamicArray.size - 1;
            //size = size - 1;
            return this.size;

        }


        public void Print()
        {

            Console.WriteLine("[{0}]", string.Join(", ", dynamicArray.Array));

        }


    }

    
}

