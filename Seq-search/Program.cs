using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int[] Data = new int[10];
            int[] Indeks = new int[10];
            int j, k;

            // input data
            for (int i = 0; i < Data.Length; i++)
            {
                Console.Write("Data ke {0} : ", i + 1);
                Data[i] = int.Parse(Console.ReadLine());
            }

            // memasukkan data yang akan dicari
            Console.Write("Masukkan data yang dicari : ");
            k = int.Parse(Console.ReadLine());

            // mencari data
            j = 0;
            for (int i = 0; i < Indeks.Length; i++)
            {
                if (Data[i] == k)
                {
                    Indeks[j] = i;
                    j++;
                    break;
                }
            }

            // jika data tidak ditemukan didalam array
            if (j > 0)
            {
                Console.Write("Data tersebut tidak ada dalam indeks ke : ");
                for (int i = 0; i < j; i++)
                {
                    Console.WriteLine("{0,3}", Indeks[i]);
                }
                Console.WriteLine();
            }

            // jika tidak ditemukan
            else
            {
                Console.WriteLine("Data tidak ada didalam array!!");
            }
            Console.ReadKey();
        }
    }
}
