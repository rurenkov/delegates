using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

  

    class Program
    {
        public static void ParceD(ref int d)
        {
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Try again..");
            }
        }

        static void Main(string[] args)
        {
            int choise = 0;  //some internal 
            int free1 = 1;  //some internal     

            int addValue = 0;
            int capacity = 1;
            int IndexToInsert = 0;
            int[] array1;


            array1 = new int[capacity];
            DynamicArray<int> dynamicArray = new DynamicArray<int>();   // publisher of the event
            var subscribers = new Subscribers();                              //subscriber  on this event
            

            dynamicArray.DataInserted += subscribers.OnDataInserted;   // registration of subscription for inserted
            dynamicArray.DataAdded += subscribers.OnDataAdded;            // registration of subscription for added
            dynamicArray.DataRemoved += subscribers.OnDataRemoved;            // registration of subscription for removed
            dynamicArray.QueueIsFull += subscribers.OnQueueIsFull;
            dynamicArray.QueueIsEmpty += subscribers.OnQueueIsEmpty;

            while (free1 > 0)
            {
                Console.WriteLine("To add value press :1, to insert :2, to remove press: 3 \n, to exit press 4");

                ParceD(ref choise);
                switch (choise)
                {
                    case 1:

                        Console.WriteLine("Enter what you want to add \n");
                        ParceD(ref addValue);                     //parce value which needs to be added
                        dynamicArray.Add(addValue);
                        dynamicArray.Print();

                        break;

                    case 2:

                        Console.WriteLine("Enter what you want to Insert \n");
                        ParceD(ref addValue);
                        Console.WriteLine("Enter # of Index to insert \n");
                        ParceD(ref IndexToInsert);
                        dynamicArray.Insert(addValue, IndexToInsert);
                        dynamicArray.Print();
                        break;

                    case 3:

                        
                        Console.WriteLine("Enter # of Index to Remove \n");
                        ParceD(ref IndexToInsert);
                        dynamicArray.Remove(IndexToInsert);
                        dynamicArray.Print();
                        break;



                    case 4:

                        {
                            free1 = 0;

                        }
                        break;
                }
            }

            Console.ReadLine();



        }

    }













}

