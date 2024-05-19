namespace WindowsFormsL1
{
    partial class FormListPenjualan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.lblHargaBelanja = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.Simpan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(431, 86);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(54, 13);
            this.lblTotalItem.TabIndex = 3;
            this.lblTotalItem.Text = "Total Item";
            // 
            // lblHargaBelanja
            // 
            this.lblHargaBelanja.AutoSize = true;
            this.lblHargaBelanja.Location = new System.Drawing.Point(431, 119);
            this.lblHargaBelanja.Name = "lblHargaBelanja";
            this.lblHargaBelanja.Size = new System.Drawing.Size(101, 13);
            this.lblHargaBelanja.TabIndex = 4;
            this.lblHargaBelanja.Text = "Total Harga Belanja";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(154, 119);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(177, 20);
            this.txtNama.TabIndex = 5;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(154, 149);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(177, 20);
            this.txtJumlah.TabIndex = 6;
            this.txtJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJumlah_KeyDown);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(154, 184);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(177, 20);
            this.txtHarga.TabIndex = 7;
            this.txtHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSimpan_KeyEnter);
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(91, 224);
            this.Simpan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(75, 23);
            this.Simpan.TabIndex = 8;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(78, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(710, 174);
            this.dataGridView2.TabIndex = 10;
            // 
            // FormListPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblHargaBelanja);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormListPenjualan";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label lblHargaBelanja;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

