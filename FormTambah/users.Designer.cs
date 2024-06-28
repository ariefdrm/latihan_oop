namespace FormTambah
{
    partial class users
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
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            button1 = new Button();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 325);
            dataGridView1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(109, 375);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(561, 135);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(561, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(177, 23);
            txtAddress.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(561, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 96);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Nama";
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Name = "users";
            Text = "users";
            Load += users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Button button1;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label3;
        private Label label2;
    }
}