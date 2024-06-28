using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppImageBox
{
    public partial class FormTambah : Form
    {
        public FormTambah()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // kode tombol simpan
            Datum mhs = new Datum();
            mhs.nim = txtNim.Text;
            mhs.nama = txtName.Text;
            mhs.tanggal_lahir = txtTanggalLahir.Text;
            mhs.program_studi = txtProgramStudi.Text;

            string mhsJsonString = JsonConvert.SerializeObject(mhs);
            string url = "https://belajar-api.unama.ac.id/api/mahasiswa";
            StringContent stringcontent = new StringContent(
                content: mhsJsonString, 
                encoding: Encoding.UTF8,
                mediaType: MediaTypeNames.Application.Json
                ) ;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
               var request = client.PostAsync(url, stringcontent).GetAwaiter().GetResult();
                if (request.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Data berhasil Disimpan");
                } else
                {
                    var responString = request.Content.ReadAsStringAsync().Result;
                    MessageBox.Show(responString);
                }
                // end kode tombol simpan


            }
        }
    }
}
