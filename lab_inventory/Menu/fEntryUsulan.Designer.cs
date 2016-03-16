namespace lab_inventory.Menu
{
    partial class fEntryUsulan
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
            this.bOpen = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.lblKodeJurusan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvTampil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bProses = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(600, 16);
            this.bOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(100, 35);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "&Buka";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(133, 16);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(459, 27);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Nama Berkas :";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(133, 51);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(459, 28);
            this.cbProdi.TabIndex = 3;
            this.cbProdi.TextChanged += new System.EventHandler(this.cbProdi_TextChanged);
            this.cbProdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProdi_KeyPress);
            // 
            // lblKodeJurusan
            // 
            this.lblKodeJurusan.AutoSize = true;
            this.lblKodeJurusan.Location = new System.Drawing.Point(133, 90);
            this.lblKodeJurusan.Name = "lblKodeJurusan";
            this.lblKodeJurusan.Size = new System.Drawing.Size(105, 20);
            this.lblKodeJurusan.TabIndex = 4;
            this.lblKodeJurusan.Text = "[kode_jurusan]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvTampil);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 440);
            this.panel1.TabIndex = 5;
            // 
            // lvTampil
            // 
            this.lvTampil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTampil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTampil.GridLines = true;
            this.lvTampil.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTampil.Location = new System.Drawing.Point(0, 20);
            this.lvTampil.Name = "lvTampil";
            this.lvTampil.Size = new System.Drawing.Size(993, 420);
            this.lvTampil.TabIndex = 1;
            this.lvTampil.UseCompatibleStateImageBehavior = false;
            this.lvTampil.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama Barang";
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jumlah Usulan";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Merk";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Harga";
            this.columnHeader5.Width = 61;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID Barang";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PREVIEW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "P&rodi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kode :";
            // 
            // bProses
            // 
            this.bProses.Location = new System.Drawing.Point(711, 16);
            this.bProses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bProses.Name = "bProses";
            this.bProses.Size = new System.Drawing.Size(100, 35);
            this.bProses.TabIndex = 8;
            this.bProses.Text = "&Proses";
            this.bProses.UseVisualStyleBackColor = true;
            this.bProses.Click += new System.EventHandler(this.bProses_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(822, 16);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 35);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "&Usulkan";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.xlsx";
            this.openFileDialog1.Filter = "Office 2007 Excel Files (*.xlsx)|*.xlsx";
            // 
            // fEntryUsulan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 594);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bProses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKodeJurusan);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.bOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fEntryUsulan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTRY USULAN";
            this.Load += new System.EventHandler(this.fEntryUsulan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Label lblKodeJurusan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvTampil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bProses;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

