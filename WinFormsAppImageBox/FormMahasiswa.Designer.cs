namespace WinFormsAppImageBox
{
    partial class FormMahasiswa
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
            pictureBox1 = new PictureBox();
            LblNim = new Label();
            LblTglLahir = new Label();
            LblProgramStudi = new Label();
            BtnLihat = new Button();
            LblName = new Label();
            LblId = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 194);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblNim
            // 
            LblNim.AutoSize = true;
            LblNim.Location = new Point(237, 99);
            LblNim.Name = "LblNim";
            LblNim.Size = new Size(30, 15);
            LblNim.TabIndex = 2;
            LblNim.Text = "Nim";
            // 
            // LblTglLahir
            // 
            LblTglLahir.AutoSize = true;
            LblTglLahir.Location = new Point(237, 145);
            LblTglLahir.Name = "LblTglLahir";
            LblTglLahir.Size = new Size(77, 15);
            LblTglLahir.TabIndex = 3;
            LblTglLahir.Text = "Tanggal Lahir";
            // 
            // LblProgramStudi
            // 
            LblProgramStudi.AutoSize = true;
            LblProgramStudi.Location = new Point(237, 191);
            LblProgramStudi.Name = "LblProgramStudi";
            LblProgramStudi.Size = new Size(83, 15);
            LblProgramStudi.TabIndex = 4;
            LblProgramStudi.Text = "Program Studi";
            // 
            // BtnLihat
            // 
            BtnLihat.Location = new Point(237, 230);
            BtnLihat.Name = "BtnLihat";
            BtnLihat.Size = new Size(75, 23);
            BtnLihat.TabIndex = 5;
            BtnLihat.Text = "Lihat";
            BtnLihat.UseVisualStyleBackColor = true;
            BtnLihat.Click += BtnLihat_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(237, 59);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 1;
            LblName.Text = "Nama";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(237, 21);
            LblId.Name = "LblId";
            LblId.Size = new Size(17, 15);
            LblId.TabIndex = 6;
            LblId.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 169);
            dataGridView1.TabIndex = 7;
            // 
            // FormMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(LblId);
            Controls.Add(BtnLihat);
            Controls.Add(LblProgramStudi);
            Controls.Add(LblTglLahir);
            Controls.Add(LblNim);
            Controls.Add(LblName);
            Controls.Add(pictureBox1);
            Name = "FormMahasiswa";
            Text = "Form3";
            Load += FormMahasiswa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblNim;
        private Label LblTglLahir;
        private Label LblProgramStudi;
        private Button BtnLihat;
        private Label LblName;
        private Label LblId;
        private DataGridView dataGridView1;
    }
}