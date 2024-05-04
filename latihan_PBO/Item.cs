using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_PBO
{
    internal class Item
    {
        string Nama;
        int Jumlah;
        int Harga;
        int Diskon;

        public Item(string nama, int jumlah, int harga, int diskon=0)
        {
            Nama = nama;
            Jumlah = jumlah;
            Harga = harga;
            Diskon = diskon;
        }
        
        public int TotalHarga()
        {
            return Jumlah * Harga;
        }

        public int HitungTotalDiskon()
        {
            return TotalHarga() * Diskon / 100;
        }
        public int HitungTotalBelanja()
        {
            return TotalHarga() - HitungTotalDiskon();
        }
        
        public void TampilHarga()
        {
           /* Console.WriteLine($"Total harga : {TotalHarga():C}");*/
           Console.WriteLine("Total harga : " + TotalHarga().ToString());
        }
        public void TampilTotalBelanja()
        {
            Console.WriteLine("Total harga setelah diskon : " +  HitungTotalBelanja().ToString());
        }
    }
}
