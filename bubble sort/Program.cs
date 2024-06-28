using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, k, temp;
            bool tukar = true;
            int[] x = new int[100];
            Console.Write("masukan jumlah data :");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write(" Data ke {0} :", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("data sebelum di urut");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,3}", x[i]);
            }

            for (i = 0; i < n - 1; i++)
            {
                for (k = n - 1; k > i; k--)
                {
                   if (tukar == true)
                    {

                    }
                }
            }


            /*pengurutan*/
            for (i = 0; i < n - 1; i++)
            {
                for (k = n - 1; k > i; k--)
                {
                    if (x[k] < x[k - 1])
                    {
                        temp = x[k];
                        x[k] = x[k - 1];
                        x[k - 1] = temp;
                        
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("setelah di urut");
            for (i = 0; i < n; i++)
                Console.Write("{0,3}", x[i]);
            Console.ReadKey();
        }
    }
}
