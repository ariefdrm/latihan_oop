using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_array_2d_2
{
    internal class TesNLoop
    {
        int i, j, k;

        public void FLoop()
        {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("ini adalah for loop i");
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("ini adalah for loop j {0}", j + 1);
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("ini adalah foor loop k {0}", k + 1);
                    }
                }
            }
        }
    }
}
