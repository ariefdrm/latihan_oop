namespace CthLogin
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnDispose = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(371, 191);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDispose
            // 
            btnDispose.Location = new Point(462, 191);
            btnDispose.Name = "btnDispose";
            btnDispose.Size = new Size(75, 23);
            btnDispose.TabIndex = 1;
            btnDispose.Text = "Dispose";
            btnDispose.UseVisualStyleBackColor = true;
            btnDispose.Click += btnDispose_Click;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDispose);
            Controls.Add(btnExit);
            Name = "FormUtama";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnDispose;
    }
}