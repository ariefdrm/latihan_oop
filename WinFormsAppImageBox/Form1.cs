using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WinFormsAppImageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  pictureBox1.Load("https://i0.wp.com/joglosemarnews.com/images/2023/01/kucing.jpg?w=1280&ssl=1");
            pictureBox1.LoadAsync("https://i0.wp.com/joglosemarnews.com/images/2023/01/kucing.jpg?w=1280&ssl=1");
            MessageBox.Show("Ok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("https://dummyjson.com/products/1");

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                if (request.StatusCode == HttpStatusCode.OK)
                {
                    var responString = request.Content.ReadAsStringAsync().Result;

                    var json = JObject.Parse(responString);
                    var title = json["title"].ToString();
                    var thumb = json["thumbnail"].ToString();
                    
                    var dimension = json["dimensions"];
                    var width = dimension["width"];

                    var reviews = json["reviews"];
                    var reviewPertama = reviews[0];
                    var commentPertama = reviewPertama["comment"];
                    MessageBox.Show(commentPertama.ToString());

                    MessageBox.Show(width.ToString());
                    pictureBox1.LoadAsync(thumb);
                    label1.Text = title;
                    MessageBox.Show(title);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("https://jsonplaceholder.typicode.com/posts/1");

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync (url).GetAwaiter().GetResult();
                if (request.StatusCode == HttpStatusCode.OK)
                {
                    var responString = request.Content.ReadAsStringAsync().Result;

                    var json = JObject.Parse(responString);
                    var title = json["title"].ToString();
                    label2.Text = title;
                    MessageBox.Show(title);

                }
            }
        }
    }
}
