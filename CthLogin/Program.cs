namespace CthLogin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /* Form FormLogin = new Form();
             FormLogin.Text = "Login Page";

             Button BtnLogin = new Button();
             BtnLogin.Text = "Login";
             BtnLogin.Location = new Point(100, 100);
             FormLogin.Controls.Add(BtnLogin);

             FormLogin.ShowDialog();*/
        }
    }
}