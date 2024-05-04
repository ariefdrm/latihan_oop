using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_PBO
{
    internal class Jadwal
    {
        public MataKuliah MataKuliah;
        public Dosen Dosen;

        public string Hari;
        public string Jam;

        
        public void TampilJadwal()
        {
            Console.WriteLine("Nama Dosen : "+ Dosen.Nama);
            Console.WriteLine("Nama Nidn : "+ Dosen.Nidn);
            Console.WriteLine("Nama Mk : " + MataKuliah.Nama);
            Console.WriteLine("Hari : " + Hari);
            Console.WriteLine("jam : " + Jam);
        }
    }
}
