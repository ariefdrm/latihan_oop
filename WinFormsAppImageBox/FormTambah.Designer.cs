namespace WinFormsAppImageBox
{
    partial class FormTambah
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNim = new TextBox();
            txtName = new TextBox();
            txtTanggalLahir = new TextBox();
            txtProgramStudi = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 150);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 204);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Program Studi";
            // 
            // txtNim
            // 
            txtNim.Location = new Point(180, 39);
            txtNim.Name = "txtNim";
            txtNim.Size = new Size(161, 23);
            txtNim.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 23);
            txtName.TabIndex = 5;
            // 
            // txtTanggalLahir
            // 
            txtTanggalLahir.Location = new Point(180, 147);
            txtTanggalLahir.Name = "txtTanggalLahir";
            txtTanggalLahir.Size = new Size(161, 23);
            txtTanggalLahir.TabIndex = 6;
            // 
            // txtProgramStudi
            // 
            txtProgramStudi.Location = new Point(180, 201);
            txtProgramStudi.Name = "txtProgramStudi";
            txtProgramStudi.Size = new Size(161, 23);
            txtProgramStudi.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(157, 250);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormTambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(txtProgramStudi);
            Controls.Add(txtTanggalLahir);
            Controls.Add(txtName);
            Controls.Add(txtNim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTambah";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNim;
        private TextBox txtName;
        private TextBox txtTanggalLahir;
        private TextBox txtProgramStudi;
        private Button btnSimpan;
    }
}