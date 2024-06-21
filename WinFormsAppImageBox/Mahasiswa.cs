using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppImageBox
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Mahasiswa
    {
        List<Datum> data { get; set; }
    }
    public class Datum
    {
        public int id { get; set; }
        public string nim { get; set; }
        public string nama { get; set; }
        public string tanggal_lahir { get; set; }
        public string program_studi { get; set; }
        public string foto { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string foto_url { get; set; }
    }

    public class Root
    {
        public string status { get; set; }
        public List<Datum> data { get; set; }
    }


}
