using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lab_inventory.Menu;

namespace lab_inventory
{
    public partial class fUtama : Form
    {
        /*
         *  Proyek Manajemen Stok Barang Lab. Terpadu Poltekkes Kemenkes Surabaya
         *  Start : 18 Mei 2015 12:52
         *  Real Start : 18 Juni 2015 12:53
         *  Om Awignamastu Namah Siddham,
         *  
         *  Aplikasi Menejemen Stok Barang Lab. Terpadu Poltekkes Surabaya versi 0.1.1
         *  1. Digunakan untuk memantau, menginventaris barang habis pakai milik lab terpadu;
         *  2. Client mengolah data stok dengan menggunakan MS. Excel;
         *  3. Master membaca data dari client yg berupa file *.xlsx kemudian memprosesnya sebagai sebuah laporan.
         *  
         *  14/07/2015
         *  1. Selesai membuat .dll koneksi untuk SQLite
         *  
         *  22/12/2015
         *  1. Mengganti total dbms dari sqlite ke mariadb, karena sqlite sering mengalami database lock.
         * 
         *  05/01/2016
         *  1. Membangun form MDI, karena aplikasi ini akan berbasis MDI;
         *  2. Membuat form login, karena setiap aktivitas pengguna akan tercatat;
         *  3. Membangun tabel activity_log untuk mencatat setiap kegiatan pengguna;
         *  4. Membangun form preview usulan, cara kerja: user load data usulan, user memilih yang akan diedit atau dibatalkan (didelete).
         */
        private int childFormNumber = 0;
        static public int IdUser;

        public fUtama()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetUser(string namaNip, int idUser)
        {
            toolstripNamaNip.Text = namaNip;
            IdUser = idUser;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        public bool StatusLogin = false;
        private void entryUsulanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!StatusLogin)
                return;
            foreach (Form anyform in MdiChildren)
            {
                anyform.Close();
            }
            fEntryUsulan formEntryUsulan = new fEntryUsulan {MdiParent = this};
            formEntryUsulan.Show();
        }

        private void previewUsulanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!StatusLogin)
                return;
            foreach (Form anyform in MdiChildren)
            {
                anyform.Close();
            }
            fPreviewUsulan formPreviewUsulan = new fPreviewUsulan {MdiParent = this};
            formPreviewUsulan.Show();
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLogin = false;
            foreach (Form anyform in MdiChildren)
            {
                anyform.Close();
            }
            fLogin forLogin = new fLogin { MdiParent = this };
            forLogin.Show();
        }

        private void fUtama_Load(object sender, EventArgs e)
        {
            toolstripNamaNip.Text = "";
            fLogin login = new fLogin
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            login.Show();
        }
    }
}
