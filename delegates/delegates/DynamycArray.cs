using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class DynamicArray<T> : Dynamic<T>
    {
        public const int gFactor = 2;
        public int capacity = 1;
        public T addValue;
        public int size;
        public int IndexToInsert;
        public int maxSize = 10;

        public DynamicArray()
        {
            Array = new T[capacity];
            //capacity = array.Length;
        }


        public override void Insert(T addValue, int IndexToInsert)
        {
            if (IndexToInsert >= size && IndexToInsert < capacity)
            {
                Console.WriteLine("index is out of size");

            }

            else if (IndexToInsert < size)
            {

                for (int i = size; i > IndexToInsert; i--)  //move  to  right
                {
                    if (size == Array.Length)       // if array is full , so add capacity
                    {
                        capacity = 2 * capacity;
                        copyArray(capacity);
                        Array[i] = Array[i - 1];
                    }

                    Array[i] = Array[i - 1];
                }
                Array[IndexToInsert] = addValue;                //insert 
                size++;
            }
            OnDataInserted();  // call the method  what INSERT is done
        }


        public override void Add(T addValue)
        {
            if (size == Array.Length)
            {
                capacity = 2 * capacity;
                Console.WriteLine(capacity);//debug
                copyArray(capacity);
                Array[size] = addValue;
                size++;
            }

            else if (size < Array.Length)
            {
                Array[size] = addValue;
                size++;
            }
            OnDataAdded();   // call it after ADD is done
        }

        public override void Remove(int IndexToInsert)  // not logical name of index 
        {
            for (int i = IndexToInsert; i < (size - 1); i++)          //move elements to left
            {
                Array[i] = Array[i + 1];
                
                
            }
            size--;

            if ((capacity - size) >= size)
            {
                capacity = capacity / gFactor;
                copyArray(capacity);

            }
            OnDataRemoved();
        }

        public void copyArray(int capacity)
        {
            T[] tempArray;                     //add temp array
            tempArray = new T[size];
            Array.CopyTo(tempArray, 0);         //copy Array to tempArray
            Array = new T[capacity];             //New capacity for Array

            tempArray.CopyTo(Array, 0);
        }


        public override T Get(int IndexToInsert)  // not logical name of index 
        {
            return Array[IndexToInsert];
        }


        public bool IsFull()
        {

            if (size == maxSize)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;

        }


        public bool IsEmpty()
        {

            if (size == 0)
            {
                Console.WriteLine("QUEUE is empty");
            }

            return true;

        }




        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }

        //*************************************************************************************/
        //*************************************************************************************/
        //*************************************************************************************/
        //define events and delegates



        // 1- define delegate
        public delegate void DataInsertedEventHandler(object source, EventArgs args);
        //2 - define an event based on that delegate
        public event DataInsertedEventHandler DataInserted;
        //3- Raise the event

        protected virtual void OnDataInserted()
        {
            if (DataInserted != null)
                DataInserted(this, EventArgs.Empty);
        }
        //*********************************************/
        //*********************************************/
        //*********************************************/
        
        public delegate void DataAddedEventHandler(object source, EventArgs args);
        public event DataAddedEventHandler DataAdded;
        
        protected virtual void OnDataAdded()
        {
            if (DataAdded != null)
                DataAdded(this, EventArgs.Empty);

        }


        public delegate void DataRemovedEventHandler(object source, EventArgs args);
        public event DataRemovedEventHandler DataRemoved;

        protected virtual void OnDataRemoved()
        {
            if (DataRemoved != null)
                DataRemoved(this, EventArgs.Empty);

        }


    }



}

