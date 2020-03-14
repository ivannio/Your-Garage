using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Ford_Focus : Car
    {
        public bool IsFine => true;

        public void GetTheJobDone()
        {
            Console.WriteLine("This Ford Focus isn't the greatest car, but it gets the job done");
        }
    }
}
