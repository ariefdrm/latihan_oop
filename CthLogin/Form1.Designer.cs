namespace CthLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            Password = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.ButtonFace;
            BtnLogin.Location = new Point(260, 194);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(100, 28);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            BtnLogin.MouseEnter += BtnLogin_MouseEnter;
            BtnLogin.MouseLeave += BtnLogin_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 1;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(171, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(108, 168);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(633, 339);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(BtnLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label Password;
        private Label label2;
    }
}
