using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_array_2d_2
{
    internal class TesArray2D
    {
        public int[,] Numb = { { 10, 20 }, { 50, 100 } };

        public void Arr()
        {
            Console.WriteLine(Numb[1, 1]);
        }
    }
}
