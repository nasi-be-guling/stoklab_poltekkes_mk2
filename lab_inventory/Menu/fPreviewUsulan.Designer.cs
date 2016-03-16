namespace lab_inventory.Menu
{
    partial class fPreviewUsulan
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
            this.lvDaftar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvDaftar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 164);
            this.panel1.TabIndex = 0;
            // 
            // lvDaftar
            // 
            this.lvDaftar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDaftar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDaftar.FullRowSelect = true;
            this.lvDaftar.GridLines = true;
            this.lvDaftar.Location = new System.Drawing.Point(0, 20);
            this.lvDaftar.Name = "lvDaftar";
            this.lvDaftar.Size = new System.Drawing.Size(557, 144);
            this.lvDaftar.TabIndex = 1;
            this.lvDaftar.UseCompatibleStateImageBehavior = false;
            this.lvDaftar.View = System.Windows.Forms.View.Details;
            this.lvDaftar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvDaftar_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prodi";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tanggal";
            this.columnHeader3.Width = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Usulan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detail Usulan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelPop);
            this.panel2.Controls.Add(this.lvDetail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 275);
            this.panel2.TabIndex = 2;
            // 
            // panelPop
            // 
            this.panelPop.Controls.Add(this.button1);
            this.panelPop.Controls.Add(this.textBox1);
            this.panelPop.Location = new System.Drawing.Point(365, 3);
            this.panelPop.Name = "panelPop";
            this.panelPop.Size = new System.Drawing.Size(240, 122);
            this.panelPop.TabIndex = 2;
            this.panelPop.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 33);
            this.textBox1.TabIndex = 0;
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.GridLines = true;
            this.lvDetail.Location = new System.Drawing.Point(0, 20);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(957, 255);
            this.lvDetail.TabIndex = 2;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            this.lvDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDetail_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No.";
            this.columnHeader4.Width = 43;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nama Barang";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Jumlah Usulan";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Merk";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Harga";
            this.columnHeader8.Width = 99;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID Barang";
            this.columnHeader9.Width = 129;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bSave);
            this.panel3.Controls.Add(this.bShow);
            this.panel3.Controls.Add(this.cbProdi);
            this.panel3.Controls.Add(this.txtTahun);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(575, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 164);
            this.panel3.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(165, 110);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(152, 40);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "SAVE";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(7, 110);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(152, 40);
            this.bShow.TabIndex = 5;
            this.bShow.Text = "SHOW";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(65, 66);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(321, 28);
            this.cbProdi.TabIndex = 4;
            this.cbProdi.TextChanged += new System.EventHandler(this.cbProdi_TextChanged);
            this.cbProdi.Enter += new System.EventHandler(this.cbProdi_Enter);
            this.cbProdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProdi_KeyPress);
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(65, 33);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(127, 27);
            this.txtTahun.TabIndex = 3;
            this.txtTahun.Enter += new System.EventHandler(this.txtTahun_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prodi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tahun :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filter";
            // 
            // fPreviewUsulan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPreviewUsulan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Usulan";
            this.Load += new System.EventHandler(this.fPreviewUsulan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPop.ResumeLayout(false);
            this.panelPop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvDaftar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panelPop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}