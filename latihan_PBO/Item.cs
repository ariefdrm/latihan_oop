using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_PBO
{
    internal class Item
    {
        private string nama;

        // auto implemented property: set & get
        public string Nama
        {
            set
            {
                if (value == "")
                {
                    throw new Exception("Nama tidak boleh kosong");
                }
            }
            get
            {
                return nama;
            }
        }
        public int Jumlah { set; get; }
        public int Harga { set; get; }
        public int Diskon { set; get; }

        public Item(string nama, int jumlah, int harga, int diskon = 0)
        {
            Nama = nama;
            Jumlah = jumlah;
            Harga = harga;
            Diskon = diskon;
        }

        public Item()
        {

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
            Console.WriteLine("Total harga setelah diskon : " + HitungTotalBelanja().ToString());
        }
    }
}
