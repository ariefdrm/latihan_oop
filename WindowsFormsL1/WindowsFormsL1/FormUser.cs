using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsL1
{
    internal class FormUser : Form
    {
        public FormUser()
        {
            var btnSimpan = new Button();

            btnSimpan.Text = "Simpan";
            btnSimpan.Location = new Point(100, 70);

            var lblNama = new Label();
            lblNama.Text = "Nama User";

            this.Controls.Add(lblNama);
            this.Controls.Add(btnSimpan);
            this.Show();
        }
    }
}
