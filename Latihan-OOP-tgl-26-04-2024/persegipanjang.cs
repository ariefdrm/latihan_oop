using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP_tgl_26_04_2024
{
    internal class PersegiPanjang
    {
        private int _Panjang;
        private int _Lebar;

        public PersegiPanjang(int panjang, int lebar)
        {
            _Panjang = panjang;
            _Lebar = lebar;
        }
        public int GetLuas()
        {
            return _Panjang * _Lebar;
        }

        public int GetKeliling()
        {
            return 2 * (_Panjang + _Lebar);
        }

        public void tampilLuas()
        {
            Console.WriteLine($"Ini luas persegi panjang : {GetLuas():N}" );
        }
        public void tampilKeliling()
        {
            Console.WriteLine($"Ini keliling persegi panjang : {GetKeliling():N}" );
        }
    }
}
