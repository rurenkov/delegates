using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class MyEmptyExeption:Exception
    {
        public void GetFromEmptyBufferExeption()
        {
            Console.WriteLine("The buffer is empty (exeption)");
        }

    }
}
