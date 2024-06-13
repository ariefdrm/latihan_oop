using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticAsync
{
    internal class Reqres
    {
        public static async Task GetData()
        {
            var url = new Uri("https://reqres.in/api/users?delay=5");
            var client = new HttpClient();
            var request = await client.GetAsync(url);
            var responString = await request.Content.ReadAsStringAsync();
            Console.WriteLine(responString);
        }
    }
}
