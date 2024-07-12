using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace tesApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            var url = new Uri("https://dummyapi.online/api/movies");
            List<Movies> movies = [];

            using ()

        }
    }
}
