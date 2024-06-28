using FormTambah;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppImageBox
{
    public partial class FormMahasiswa : Form
    {
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        private void BtnLihat_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("https://belajar-api.unama.ac.id/api/mahasiswa/14");

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                if (request.StatusCode == HttpStatusCode.OK)
                {
                    var ResponString = request.Content.ReadAsStringAsync().Result;

                    var json = JObject.Parse(ResponString);

                    var data = json["data"];
                    mahasiswa mahasiswa = JsonConvert.DeserializeObject<mahasiswa>(data.ToString());

                    // id
                    var id = mahasiswa.id;
                    LblId.Text = id;

                    // nama
                    var name = mahasiswa.nama;
                    LblName.Text = name;

                    // nim
                    var nim = mahasiswa.nim;
                    LblNim.Text = nim;

                    // tanggal lahir
                    var TglLahir = mahasiswa.tanggal_lahir;
                    LblTglLahir.Text = TglLahir;

                    // program studi 
                    var ProgramStudi = mahasiswa.program_studi;
                    LblProgramStudi.Text = ProgramStudi;

                    // foto profile
                    var ProfilePicture = mahasiswa.Foto;
                    pictureBox1.LoadAsync(ProfilePicture);

                }
            }
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
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
