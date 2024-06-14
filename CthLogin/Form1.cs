using CthLogin.Interface;

namespace CthLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.Text = "Simpan";
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.Text = "login";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Password = txtPassword.Text;

            if (UserName == "admin" && Password == "admin")
            {
                MessageBox.Show("login berhasil");
                new FormUtama().ShowDialog();
            }
            else
                MessageBox.Show("login gagal");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TxtValidation.txtValidation(e, txtUsername, txtPassword);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLogin.PerformClick();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            LogitechMouse mouse = new LogitechMouse();
            MouseIndonesia mouseIndonesia = new MouseIndonesia();
            laptop laptop = new laptop();
            laptop.SetMouse(mouseIndonesia);
            MessageBox.Show(laptop.OnRightClick());
        }
    }
}
