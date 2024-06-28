namespace FormTambah
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtNim = new TextBox();
            txtName = new TextBox();
            txtTanggalLahir = new TextBox();
            button1 = new Button();
            cmbProgramStudi = new ComboBox();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 158);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 208);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 3;
            label5.Text = "Program Studi";
            // 
            // txtNim
            // 
            txtNim.Location = new Point(161, 42);
            txtNim.Name = "txtNim";
            txtNim.Size = new Size(177, 23);
            txtNim.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 5;
            // 
            // txtTanggalLahir
            // 
            txtTanggalLahir.Location = new Point(161, 155);
            txtTanggalLahir.Name = "txtTanggalLahir";
            txtTanggalLahir.Size = new Size(177, 23);
            txtTanggalLahir.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(135, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbProgramStudi
            // 
            cmbProgramStudi.DisplayMember = "TI";
            cmbProgramStudi.FormattingEnabled = true;
            cmbProgramStudi.Items.AddRange(new object[] { "TI", "SK", "SI" });
            cmbProgramStudi.Location = new Point(161, 208);
            cmbProgramStudi.Name = "cmbProgramStudi";
            cmbProgramStudi.Size = new Size(177, 23);
            cmbProgramStudi.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(454, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(334, 205);
            dataGridView1.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(431, 267);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(cmbProgramStudi);
            Controls.Add(button1);
            Controls.Add(txtTanggalLahir);
            Controls.Add(txtName);
            Controls.Add(txtNim);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtNim;
        private TextBox txtName;
        private TextBox txtTanggalLahir;
        private Button button1;
        private ComboBox cmbProgramStudi;
        private DataGridView dataGridView1;
        private Button btnRefresh;
    }
}
