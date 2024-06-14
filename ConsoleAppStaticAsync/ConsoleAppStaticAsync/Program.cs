// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using ConsoleAppStaticAsync;
using System.Runtime.InteropServices;

namespace ConsoleNetApp
{
    class Program
    {
        // Contoh cara pakai asynchronous
        static async Task Job2()
        {
            await Task.Delay(5000);
            Console.WriteLine("Job 2 Ok");
        }
        static void Job2Sync()
        {
            
        }

        void Job3()
        {
            Console.WriteLine("Job 3 Ok");
        }
        static void Main(string[] args)
        {
           /* int hasil;
            hasil = hitung.tambah(10, 20);
            Console.WriteLine("Hasil tambah : " + hasil);

            hasil = hitung.kurang(50, 20);
            Console.WriteLine("hasil kurang : " + hasil);*/

            Program program = new Program();

            Console.WriteLine("Job 1 Ok");
            // Reqres.GetData();
            Job2();
            program.Job3();
            Console.ReadKey();
        }
    }
}