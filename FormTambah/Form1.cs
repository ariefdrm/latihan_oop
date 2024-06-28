using System.Net.Mime;
using System.Text;
using System.Text.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormTambah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mahasiswa mhs = new mahasiswa();
            mhs.nim = txtNim.Text;
            mhs.nama = txtName.Text;
            mhs.tanggal_lahir = txtTanggalLahir.Text;
            mhs.program_studi = cmbProgramStudi.Text;
            string mhsJsonString = JsonConvert.SerializeObject(mhs);
            string url = "https://belajar-api.unama.ac.id/api/mahasiswa";
            StringContent stringcontent = new StringContent(
                content: mhsJsonString,
                encoding: Encoding.UTF8,
                mediaType: MediaTypeNames.Application.Json
                );
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var request = client.PostAsync(url, stringcontent).GetAwaiter().GetResult();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            var url = new Uri("https://belajar-api.unama.ac.id/api/mahasiswa");
            List<mahasiswa> ListMahasiswa = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responString = request.Content?.ReadAsStringAsync().Result;
                mahasiswa mahasiswa = JsonConvert.DeserializeObject<mahasiswa>(responString);


                var responJson = JObject.Parse(responString);
                var data = responJson["data"];
                ListMahasiswa = JsonConvert.DeserializeObject<List<mahasiswa>>(data.ToString());
                dataGridView1.DataSource = ListMahasiswa;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var url = new Uri("https://belajar-api.unama.ac.id/api/mahasiswa");
            List<mahasiswa> ListMahasiswa = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responString = request.Content?.ReadAsStringAsync().Result;
                mahasiswa mahasiswa = JsonConvert.DeserializeObject<mahasiswa>(responString);


                var responJson = JObject.Parse(responString);
                var data = responJson["data"];
                ListMahasiswa = JsonConvert.DeserializeObject<List<mahasiswa>>(data.ToString());
                dataGridView1.DataSource = ListMahasiswa;
            }
        }
    }
}