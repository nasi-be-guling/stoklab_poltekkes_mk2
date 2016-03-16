namespace lab_inventory.Menu
{
    partial class FEntryPakaiClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lSpesifikasi = new System.Windows.Forms.Label();
            this.lNamaBarang = new System.Windows.Forms.Label();
            this.lProdi = new System.Windows.Forms.Label();
            this.txtJumlahPakai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 295);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(890, 275);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama Barang";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Spesifikasi";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Merk";
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sisa Stok";
            this.columnHeader5.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DAFTAR BARANG HABIS PAKAI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lSpesifikasi);
            this.panel2.Controls.Add(this.lNamaBarang);
            this.panel2.Controls.Add(this.lProdi);
            this.panel2.Controls.Add(this.txtJumlahPakai);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 134);
            this.panel2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "PEMAKAIAN PER BARANG";
            // 
            // lSpesifikasi
            // 
            this.lSpesifikasi.AutoSize = true;
            this.lSpesifikasi.Location = new System.Drawing.Point(132, 78);
            this.lSpesifikasi.Name = "lSpesifikasi";
            this.lSpesifikasi.Size = new System.Drawing.Size(44, 20);
            this.lSpesifikasi.TabIndex = 11;
            this.lSpesifikasi.Text = "Prodi";
            // 
            // lNamaBarang
            // 
            this.lNamaBarang.AutoSize = true;
            this.lNamaBarang.Location = new System.Drawing.Point(132, 53);
            this.lNamaBarang.Name = "lNamaBarang";
            this.lNamaBarang.Size = new System.Drawing.Size(44, 20);
            this.lNamaBarang.TabIndex = 10;
            this.lNamaBarang.Text = "Prodi";
            // 
            // lProdi
            // 
            this.lProdi.AutoSize = true;
            this.lProdi.Location = new System.Drawing.Point(132, 27);
            this.lProdi.Name = "lProdi";
            this.lProdi.Size = new System.Drawing.Size(44, 20);
            this.lProdi.TabIndex = 9;
            this.lProdi.Text = "Prodi";
            // 
            // txtJumlahPakai
            // 
            this.txtJumlahPakai.Location = new System.Drawing.Point(136, 100);
            this.txtJumlahPakai.Name = "txtJumlahPakai";
            this.txtJumlahPakai.Size = new System.Drawing.Size(59, 27);
            this.txtJumlahPakai.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pemakaian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Spesifikasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prodi";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(790, 9);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(112, 45);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "&SAVE";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // FEntryPakaiClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 459);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FEntryPakaiClient";
            this.Text = "ENTRY PEMAKAIAN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lSpesifikasi;
        private System.Windows.Forms.Label lNamaBarang;
        private System.Windows.Forms.Label lProdi;
        private System.Windows.Forms.TextBox txtJumlahPakai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label13;
    }
}