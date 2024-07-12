namespace tesApi
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
            btnRefersh = new Button();
            pictureBox1 = new PictureBox();
            lblMovie = new Label();
            lblRating = new Label();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(395, 311);
            dataGridView1.TabIndex = 0;
            // 
            // btnRefersh
            // 
            btnRefersh.Location = new Point(67, 350);
            btnRefersh.Name = "btnRefersh";
            btnRefersh.Size = new Size(75, 23);
            btnRefersh.TabIndex = 1;
            btnRefersh.Text = "Refersh";
            btnRefersh.UseVisualStyleBackColor = true;
            btnRefersh.Click += btnRefersh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(451, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 183);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new Point(669, 29);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(40, 15);
            lblMovie.TabIndex = 3;
            lblMovie.Text = "Movie";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(669, 73);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(41, 15);
            lblRating.TabIndex = 4;
            lblRating.Text = "Rating";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(478, 227);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            comboBox1.Location = new Point(674, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnSearch);
            Controls.Add(lblRating);
            Controls.Add(lblMovie);
            Controls.Add(pictureBox1);
            Controls.Add(btnRefersh);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRefersh;
        private PictureBox pictureBox1;
        private Label lblMovie;
        private Label lblRating;
        private Button btnSearch;
        private ComboBox comboBox1;
    }
}
