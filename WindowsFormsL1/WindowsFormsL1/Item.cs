using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsL1
{
    internal class Item
    {
        // auto implemented property: set & get
        /*private string nama;

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
        }*/

        // end contoh implemented property : set & get

        public string Nama { get; set; }

        int jumlah;
        public int Jumlah
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Jumlah tidak boleh 0");
                }
                jumlah = value;
            }
            get
            {
                return jumlah;
            }
        }
        int harga;
        public int Harga
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Jumlah tidak boleh 0");
                }
                harga = value;
            }
            get
            {
                return harga;
            }
        }

        int diskon;
        public int Diskon { set; get; }

        public int TotalHarga { set; get; }

        public Item(string nama, int jumlah, int harga, int diskon = 0)
        {
            Nama = nama;
            Jumlah = jumlah;
            Harga = harga;
            Diskon = diskon;
        }

        public Item() { }

        public int GetTotalHarga()
        {
            return HitungTotalHarga();
        }

        public int HitungTotalHarga()
        {
            TotalHarga = Jumlah * Harga;
            return TotalHarga;
        }

        public int HitungTotalDiskon()
        {
            return HitungTotalHarga() * Diskon / 100;
        }
        public int HitungTotalBelanja()
        {
            return HitungTotalHarga() - HitungTotalDiskon();
        }

        public void TampilHarga()
        {
            /* Console.WriteLine($"Total harga : {TotalHarga():C}");*/
            Console.WriteLine("Total harga : {0:N}", HitungTotalHarga().ToString());
        }
        public void TampilTotalBelanja()
        {
            Console.WriteLine("Total harga setelah diskon : {0:N}", HitungTotalBelanja().ToString());
        }
    }
}
