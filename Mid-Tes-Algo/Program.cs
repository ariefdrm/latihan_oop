using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Tes_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[,] hari = new string[2, 5]; 
            string[] Hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jum'at" };
            string[] Nama = new string[2];
            double[,] JHP = new double[2, 5];
            double[,] Up = new double[2, 5];
            double[,] Bonus = new double[2, 5];
            double[,] TotalUpah = new double[2, 5];
            double[] JumlahTotalUpah = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                Console.Write("Nama : {0}", Nama[i]);
                Nama[i] = Console.ReadLine();
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                   /* // input hari 
                    Console.Write("Hari : ");
                    hari[i, j] = Console.ReadLine();*/
                   Console.Write("{0} \n", Hari[j]);
                    
                    // input jumlah hasil panen
                    Console.Write("Jumlah hasil panen : ");
                    JHP[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2;i++)
            {
                for (int j = 0; j < 5; j++)     
                {   
                    if (JHP[i, j] >= 2000)
                    {
                        Bonus[i, j] = 100;
                        // menghitung total bonus
                        Bonus[i, j] = (JHP[i, j] - 2000) * 100;
                    } else
                    {
                        Bonus[i, j] = 0;
                    }

                    // menghitung upah panen
                    Up[i, j] = JHP[i, j] * 250;

                    // menghitung total upah
                    TotalUpah[i, j] = Up[i, j] + Bonus[i, j];

                    // menhitung jumlah total upah
                    JumlahTotalUpah[i] = JumlahTotalUpah[i] + TotalUpah[i, j];
                }
            }

            Console.Clear();
            for (int i = 0; i < 2;i++)
            {
                Console.WriteLine("Nama : {0}", Nama[i]);
                Console.WriteLine("=================================================================");
                Console.WriteLine("Hari      Jumlah Hasil Panen (KG)  Upah Panen  Bonus  Total Bonus");
                Console.WriteLine("=================================================================");

                for (int j = 0;j < 5;j++)
                {
                    Console.WriteLine("{0, -9} {1, 12} {2, 20} {3, 7} {4, 10}", /*hari[i, j]*/ Hari[j], JHP[i, j], Up[i, j], Bonus[i, j], TotalUpah[i, j]);
                }
                Console.WriteLine("=================================================================");
                Console.Write("Total  : {0, 55} \n", JumlahTotalUpah[i]);
            }

            Console.ReadKey();
        }
    }
}
