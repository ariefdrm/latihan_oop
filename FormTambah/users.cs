using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTambah
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void users_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        public void tampildata()
        {
            var url = new Uri("https://667e2a47297972455f674ca6.mockapi.io/tugas/api/v1/users");
            List<ListUsers> ListData = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responstring = request.Content?.ReadAsStringAsync().Result;
                ListData = JsonConvert.DeserializeObject<List<ListUsers>>(responstring);
                dataGridView1.DataSource = ListData.OrderByDescending(users => users.id).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListUsers users = new ListUsers();
            users.name = txtName.Text;
            users.address = txtAddress.Text;
            string userJsonString = JsonConvert.SerializeObject(users);
            string url = "https://667e2a47297972455f674ca6.mockapi.io/tugas/api/v1/users";
            StringContent stringContent = new StringContent(
                    encoding: Encoding.UTF8,
                    content: userJsonString,
                    mediaType: MediaTypeNames.Application.Json
                );
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var request = client.PostAsync(url, stringContent).GetAwaiter().GetResult();
                if (request.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Data berhasil disimpan");
                }
                else
                {
                    var responstring = request.Content.ReadAsStringAsync().Result;
                    MessageBox.Show(responstring);
                }
            }
        }
    }
}