using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_PBO
{
    internal class MataKuliah
    {
        public string Kode;
        public string Nama;
        public int Sks;

        public MataKuliah(string kode, string nama, int sks)
        {
            Kode = kode;
            Nama = nama;
            Sks = sks;
        }
        public MataKuliah() { }

        public void setSks(int sks) 
        {
            if (sks >= 7) 
            {
                throw new Exception("sks tidak benar");
            }
            Sks = sks;
        }
    }
}
