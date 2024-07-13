using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;

namespace uts_8020230033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            books books = new books();
            books.title = txtTitle.Text;
            books.author = txtAuthor.Text;
            books.publisher = txtPublisher.Text;
            string booksJSonString = JsonConvert.SerializeObject(books);
            string url = "https://667e2a47297972455f674ca6.mockapi.io/tugas/api/v1/books";
            StringContent stringContent = new StringContent(
                    content: booksJSonString,
                    encoding: Encoding.UTF8,
                    mediaType: MediaTypeNames.Application.Json
                ) ;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var url = new Uri("https://667e2a47297972455f674ca6.mockapi.io/tugas/api/v1/books");
            List<books> ListBooks = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var responString = request.Content?.ReadAsStringAsync().Result;
                ListBooks = JsonConvert.DeserializeObject<List<books>>(responString);
                dataGridView1.DataSource = ListBooks;
            }
        }
    }
}
