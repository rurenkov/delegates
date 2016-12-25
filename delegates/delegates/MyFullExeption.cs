using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class MyFullExeption:Exception
    {
        public void AddToFullBufferExeption()
        {
            Console.WriteLine("The buffer already full (exeption)");
        }
       

    }
}
