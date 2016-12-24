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

        public bool IsFull()
        {

            if (dynamicArray.size == dynamicArray.maxSize)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;

        }


        public bool IsEmpty()
        {

            if (dynamicArray.size == 0)
            {
                Console.WriteLine("QUEUE is empty");
            }
     //       OnQueueIsEmpty();  // call method which should notify all the subscribers
            return true;

        }

      






    }
}
