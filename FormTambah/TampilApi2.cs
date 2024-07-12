using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTambah
{
    public partial class TampilApi2 : Form
    {
        public TampilApi2()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var url = new Uri("https://dummyapi.online/api/movies");
            List<Movies> movies = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responstring = request.Content?.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movies>>(responstring);
                dataGridView1.DataSource = movies.OrderByDescending(movies => movies.id).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var url = new Uri("https://dummyapi.online/api/movies");
            List<Movies> movies = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responstring = request.Content?.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movies>>(responstring);
                
            }
        }
    }
}
