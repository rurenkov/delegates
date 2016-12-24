using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class Subscribers
    {
        // create event hendler
        public void OnDataInserted(object source, EventArgs e)
        {
            Console.WriteLine("The value was inserted successfully(Events)");
        }

        public void OnDataAdded(object source, EventArgs e)
        {
            Console.WriteLine("The value was Added successfully (Events)");
        }

        public void OnDataRemoved(object source, EventArgs e)
        {
            Console.WriteLine("The value was DELETED successfully (Events)");
        }



    }

}
