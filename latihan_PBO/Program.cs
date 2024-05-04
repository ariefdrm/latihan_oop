using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_PBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MataKuliah mk1 = new MataKuliah(nama : "agus", kode : "PT0001", sks : 3);

            /*  MataKuliah mk1 = new MataKuliah();
              mk1.Nama = "Dasar pemrograman";
              mk1.setSks(7);
              mk1.Kode = "PT0001";

              Dosen dosen = new Dosen();
              dosen.Nama = "agus";
              dosen.Nidn = "10001";

              Jadwal jd = new Jadwal();
              jd.MataKuliah = mk1;
              jd.Dosen = dosen;
              jd.Hari = "jumat";
              jd.Jam = "08.00";
              jd.TampilJadwal();*/

            Item itm = new Item(nama: "minyak goren", 2, 10000, 10);
            itm.TotalHarga();
            itm.TampilHarga();
            itm.TampilTotalBelanja();

            Console.ReadKey();
        }
    }
    class Dosen
    {
        public string Nidn;
        public string Nama;
        public Dosen(string nidn, string nama)
        {
            Nidn = nidn;
            Nama = nama;
        }
        public Dosen() { }
    }
}
