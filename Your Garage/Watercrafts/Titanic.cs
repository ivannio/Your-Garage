using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Titanic : Watercraft
    {
        public bool Unsinkable { get; set; }

        public void MakeContactWithIceberg()
        {
            Unsinkable = false;
            Console.WriteLine($"So they told me it was unsinkable but it turns out that's {Unsinkable}");
        }
    }
}
