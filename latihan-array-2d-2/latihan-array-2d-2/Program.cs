using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_array_2d_2
{
    internal class Program
    {
        // deklarasi array & array 2d
        public string[] Name = new string[2];
        public string[,] Mk = new string[2, 2];
        public double[,] Nilai = new double[2, 2];
        static void Main(string[] args)
        {
            /* Program program = new Program();
             program.InputData();
             program.TampilData();*/

            /* TesArray2D array2D = new TesArray2D();
             array2D.Arr();*/

            TesNLoop Floop = new TesNLoop();
            Floop.FLoop();
            Console.ReadKey();
        }

        public void InputData()
        {
            // untuk menginputkan nilai baris & kolom pada array 2d
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("masukkan data ke : {0}", i + 1);
                Console.Write("Nama     : ");
                Name[i] = Console.ReadLine();
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Mata kuliah : ");
                    Mk[i, j] = Console.ReadLine();
                    Console.Write("Nilai    : ");
                    Nilai[i, j] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }

        public void TampilData()
        {
            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Nama     :{0}", Name[i]);
                Console.WriteLine("======================");
                Console.WriteLine("Nama             Nilai");
                Console.WriteLine("======================");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0,-16} {1,2}", Mk[i, j], Nilai[i, j]);
                }
                Console.WriteLine("======================");
                Console.WriteLine();
            }
        }
    }
}
