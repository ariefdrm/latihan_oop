namespace uts_8020230033
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            button1 = new Button();
            btnRefresh = new Button();
            comboCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(361, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(409, 240);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 189);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "category";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(81, 26);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(81, 76);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(178, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(81, 133);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(178, 23);
            txtPublisher.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(58, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(331, 284);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // comboCategory
            // 
            comboCategory.DisplayMember = "1";
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Hip Hop", "Electronic", "Folk", "Jazz" });
            comboCategory.Location = new Point(78, 189);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 11;
            comboCategory.ValueMember = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboCategory);
            Controls.Add(btnRefresh);
            Controls.Add(button1);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private Button button1;
        private Button btnRefresh;
        private ComboBox comboCategory;
    }
}
