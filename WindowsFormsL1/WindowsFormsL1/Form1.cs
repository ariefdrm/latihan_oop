using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Penjualan penjualan = new Penjualan();
        private void Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.Nama = txtNama.Text;
                item.Jumlah = int.Parse(txtJumlah.Text);
                item.Harga = int.Parse(txtHarga.Text);

                penjualan.TambahItem(item);
                lblTotalItem.Text = "Total item : " + penjualan.GetTotalItem().ToString();
                lblHargaBelanja.Text = "Total Belanja : " + penjualan.GetTotalBelanja().ToString();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = penjualan.GetItems();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ops.. Terjadi kesalahan" + err.Message);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtJumlah.Focus();
            }
        }

        private void txtJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtHarga.Focus();
        }

        private void txtSimpan_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Simpan.PerformClick();
            }
        }
    }
}
