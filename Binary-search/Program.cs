using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int[] Data = { 3, 9, 11, 12, 15, 17, 23, 31, 35 };
            int l, r, m, ktm;
            int n = Data.Length;
            int cari;
            l = 0;
            r = n - 1;
            ktm = 0;

            // list data
            foreach (int i in Data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine( );

            // input data yang dicari
            Console.Write("masukkan data : ");
            cari = int.Parse(Console.ReadLine());

            // 
            while (l <= r && ktm == 0) { 
                m = (l + r) / 2;
                Console.WriteLine("data tengah :{0}", m);
                if (Data[m] == cari)
                {
                    ktm = 1;
                } else if (cari <= Data[m])
                {
                    Console.WriteLine("cari di kiri");
                    r = m - 1;
                } else
                {
                    l = m + 1;
                    Console.WriteLine("cari dikanan");
                }
            }

            if (ktm == 1)
                Console.WriteLine("data ada!!!");
            else
                Console.WriteLine("data tidah ada!!!");

            Console.ReadKey();
        }
    }
}
