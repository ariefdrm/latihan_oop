// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using ConsoleAppStaticAsync;

int hasil = hitung.tambah(10, 20);
Console.WriteLine(hasil);

Console.WriteLine("Job 1 Ok");
Reqres.GetData();
Job3();
Console.ReadKey();

async void Job2()
{
    await Task.Delay(5000);
    Console.WriteLine("Job 2 Ok");
}

void Job3()
{
    Console.WriteLine("Job 3 Ok");
}

