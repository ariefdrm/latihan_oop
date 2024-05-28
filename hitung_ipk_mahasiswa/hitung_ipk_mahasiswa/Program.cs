﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitung_ipk_mahasiswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Name = new string[3];
            string[,] MataKuliah = new string[3, 3];
            int[,] Sks = new int[3, 3];
            double[,] Nilai = new double[3, 3];
            string[,] Huruf = new string[3, 3];
            double[,] Bobot = new double[3, 3];
            double[,] Kredit = new double[3, 3];
            double[] TSks = new double[3];
            double[] TKredit = new double[3];
            double[] Ip = new double[3];

            for (int x = 0; x < 3; x++)
            {
                Console.Clear();
                Console.Write("Nama : ");
                Name[x] = Console.ReadLine();
                Console.WriteLine();
                for (int y = 0; y < 2; y++)
                {
                    // input matakuliah
                    Console.Write("MataKuliah : ");
                    MataKuliah[x, y] = Console.ReadLine();

                    // intput Sks
                    Console.Write("Sks : ");
                    Sks[x, y] = int.Parse(Console.ReadLine());

                    // input nilai
                    Console.Write("Nilai : ");
                    Nilai[x, y] = double.Parse(Console.ReadLine());

                    // nilai huruf && nilai bobot
                    if (Nilai[x, y] >= 80)
                    {
                        Huruf[x, y] = "A";
                        Bobot[x, y] = 4;
                    } else if (Nilai[x, y] >= 75)
                    {
                        Huruf[x, y] = "B+";
                        Bobot[x, y] = 3.5; 
                    } else if (Nilai[x, y] >= 70)
                    {
                        Huruf[x, y] = "B";
                        Bobot[x, y] = 3;
                    } else if (Nilai[x, y] >= 65)
                    {
                        Huruf[x, y] = "C+";
                        Bobot[x, y] = 2.5;
                    } else if (Nilai[x, y] >= 60)
                    {
                        Huruf[x, y] = "C";
                        Bobot[x, y] = 2;
                    }

                    // hitung kredit
                    Kredit[x, y] = Sks[x, y] * Bobot[x, y];

                    // total sks
                    TSks[x] = TSks[x] + Sks[x, y];

                    // total kredit
                    TKredit[x] += Kredit[x, y];

                    // hitung ip
                    Ip[x] = TSks[x] / TKredit[x];
                }
            }

            Console.Clear();
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; x < 3; y++)
                {
                    // tampil data
                    Console.Write("Nama :{0}", Name[x]);
                    Console.WriteLine();
                    Console.WriteLine("=================================================");
                    Console.WriteLine("MataKuliah           Sks Nilai Huruf Bobot Kredit");
                    Console.WriteLine("=================================================");
                    Console.WriteLine("{0, -21} {1, 22} {2,25} {3, 31}", MataKuliah[x,y] , Sks[x, y], Nilai[x, y], Huruf[x, y]);
                }
            }

            Console.ReadKey();
        }
    }
}
