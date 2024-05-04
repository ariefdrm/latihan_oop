using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_OOP_tgl_26_04_2024
{
    internal class Penjualan
    {
        private string _NamaBarang;
        private int _Jumlah, _Harga;
        public Penjualan(string NamaBarang, int Jumlah, int Harga) 
        {
            _NamaBarang = NamaBarang;
            _Jumlah = Jumlah;
            _Harga = Harga;
        }
        public int GetTotalHarga()
        {
            return _Harga * _Jumlah;
        }

        public int TotalDiskon(int Diskon)
        {
            return GetTotalHarga() * Diskon / 100;
        }
        public int HargaFinal(int Diskon)
        {
            return GetTotalHarga() - TotalDiskon(Diskon);
        }
        public void TampilDiskon()
        {
            Console.WriteLine($"Harga diskon 10% : {TotalDiskon(10):N}");
            Console.WriteLine($"Harga setelah diskon : {HargaFinal(10):N}");
        } 
    }
}
