using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class King_Of_Red_Lions : Watercraft
    {
        public bool IsSentient => true;

        public void GiveLinkTheWindWaker()
        {
            Console.WriteLine("Here ya go kid");
        }
    }
}
