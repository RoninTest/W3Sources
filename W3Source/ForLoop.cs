using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Source
{
    public class ForLoop
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
        public ForLoop()
        {

        }

        public void returnSumOfEvenNumbers()
        {
            int i;
            int j = 0;

            for (i = 1; i < value1; i++)
            {
               j = j + i;
            }

            value2 = j;
        }
    }
}
