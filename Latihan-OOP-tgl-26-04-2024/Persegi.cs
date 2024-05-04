using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP_tgl_26_04_2024
{
    internal class Persegi
    {
        private int _sisi;
        public Persegi(int sisi) {
            _sisi = sisi;
        }
        public int GetLuas()
        {
            return _sisi * _sisi;
        }
        public int GetKeliling()
        {
            return 4 * _sisi;
        }
        public void TampilLuas()
        {
            Console.WriteLine($"Ini luas persegi : {GetLuas():n}");
        }
        public void TampilKeliling()
        {
            Console.WriteLine($"ini keliling persegi : {GetKeliling():n}");
        }
    }
}
