using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppImageBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = comboBox1.Text;

            Uri url = new Uri("https://dummyjson.com/products/" + id);
            using (HttpClient client = new HttpClient())
            {

                var request = client.GetAsync(url).GetAwaiter().GetResult();
                if (request.StatusCode == HttpStatusCode.OK)
                {
                    var responString = request.Content.ReadAsStringAsync().Result;

                    var json = JObject.Parse(responString);

                    // judul
                    var title = json["title"].ToString();
                    label1.Text = title;

                    // keterangan
                    var description = json["description"].ToString();
                    label2.Text = description;

                    // harga
                    var price = json["price"];
                    label3.Text = price.ToString();

                    // stok / kesedian barang
                    var stok = json["stock"];
                    label4.Text = stok.ToString();

                    // category
                    var category = json["category"].ToString();
                    label5.Text = category;

                    // picture box
                    var thumb = json["thumbnail"].ToString();
                    pictureBox1.LoadAsync(thumb);

                }
            }
        }

   
    }
}
