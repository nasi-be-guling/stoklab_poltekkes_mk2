using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _connectMySQL;

namespace lab_inventory.Menu
{
    public partial class fPreviewUsulan : Form
    {
        #region KOMPONEN WAJIB
        readonly CConnection _connect = new CConnection();
        private MySqlConnection _connection;
        private string _sqlQuery;
        private readonly string _configurationManager = Properties.Settings.Default.Setting;
        #endregion

        private class Jurusan
        {
            private int id;
            private string kode;
            private string nama;

            public Jurusan(int id, string kode, string nama)
            {
                this.id = id;
                this.kode = kode;
                this.nama = nama;
            }

            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }

            public string Kode
            {
                get { return kode; }
                set { kode = value; }
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        }

        List<Jurusan> _jurusans = new List<Jurusan>();
        List<ListViewItem> _listViewItemsDaftar = new List<ListViewItem>();
        List<ListViewItem> _listViewItemsDetail = new List<ListViewItem>();

        public fPreviewUsulan()
        {
            InitializeComponent();
        }

        private void fPreviewUsulan_Load(object sender, EventArgs e)
        {
            Cleanse();
            SelectDataJurusan();
        }

        private void SelectDataJurusan()
        {
            _jurusans.Clear();
            cbProdi.Items.Clear();
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            MySqlDataReader reader = _connect.Reading("select * from lab_inventory.prodi", _connection, ref errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbProdi.Items.Add(Convert.ToString(reader[2]));
                    _jurusans.Add(new Jurusan(Convert.ToInt16(reader[0]), Convert.ToString(reader[1]),
                        Convert.ToString(reader[2])));
                }
                reader.Close();
            }
            _connection.Close();
        }

        private void Cleanse()
        {
            //_jurusans.Clear();
            lvDaftar.Items.Clear();
            lvDetail.Items.Clear();
            _listViewItemsDaftar.Clear();
            _listViewItemsDetail.Clear();
            txtTahun.Text = "";
            cbProdi.Text = "";
        }

        private void cbProdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private int idJurusan;
        private void cbProdi_TextChanged(object sender, EventArgs e)
        {
            var query = (from i in _jurusans where i.Nama == cbProdi.Text select i);
            foreach (var item in query)
            {
                idJurusan = item.Id;
            }
        }

        private int _statusFilter;

        private void bShow_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTahun.Text, "[^0-9]"))
            {
                MessageBox.Show("Harap mengisi angka");
                txtTahun.SelectAll();
                txtTahun.Focus();
                return;
            }

            string masterQuery = "SELECT\n" +
                                 "prodi.nama,\n" +
                                 "DATE_FORMAT(usulan.tglUsul,'%b %d %Y %h:%i %p'),\n" +
                                 "usulan.id,\n" +
                                 "prodi.id\n" +
                                 "FROM\n" +
                                 "usulan\n" +
                                 "LEFT OUTER JOIN prodi ON prodi.id = usulan.idJurusan where usulan.status = 1";

            _listViewItemsDaftar.Clear();
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (string.IsNullOrEmpty(txtTahun.Text) && string.IsNullOrEmpty(cbProdi.Text))
            {
                _sqlQuery = masterQuery;
            }

            if (!string.IsNullOrEmpty(txtTahun.Text) && !string.IsNullOrEmpty(cbProdi.Text))
            {
                _sqlQuery = "SELECT\n" +
                            "prodi.nama,\n" +
                            "DATE_FORMAT(usulan.tglUsul,'%b %d %Y %h:%i %p'),\n" +
                            "usulan.id,\n" +
                            "prodi.id\n" +
                            "FROM\n" +
                            "usulan\n" +
                            "LEFT OUTER JOIN prodi ON prodi.id = usulan.idJurusan\n" +
                            "WHERE\n" +
                            "year(usulan.tglUsul) = " + txtTahun.Text + " AND\n" +
                            "usulan.idJurusan = " + idJurusan + " and usulan.status = 1";
            }

            if (_statusFilter == 1)
            {
                if (string.IsNullOrEmpty(txtTahun.Text))
                    return;
                _sqlQuery = masterQuery + " and year(usulan.tglUsul) = " + txtTahun.Text + " ";
            }

            if (_statusFilter == 2)
            {
                _sqlQuery = masterQuery + " and usulan.idJurusan = " + idJurusan + " ";
            }

            MySqlDataReader reader = _connect.Reading(_sqlQuery, _connection,
                ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (reader.HasRows)
            {
                int noUrut = 1;
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(noUrut++.ToString());
                    items.SubItems.Add(reader[0].ToString());
                    items.SubItems.Add(reader[1].ToString());
                    items.SubItems.Add(reader[2].ToString());
                    items.SubItems.Add(reader[3].ToString());
                    _listViewItemsDaftar.Add(items);
                }
                reader.Close();
                lvDaftar.BeginUpdate();
                lvDaftar.Items.Clear();
                lvDaftar.Items.AddRange(_listViewItemsDaftar.ToArray());
                lvDaftar.EndUpdate();
            }
            else
            {
                lvDaftar.Items.Clear();
            }
            _connection.Close();
        }

        private void txtTahun_Enter(object sender, EventArgs e)
        {
            _statusFilter = 1;
        }

        private void cbProdi_Enter(object sender, EventArgs e)
        {
            _statusFilter = 2;
        }

        private void RefreshLvDetail(string idUsulan)
        {
            _listViewItemsDetail.Clear();
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            _sqlQuery = "SELECT\n" +
                        "barang.nama,\n" +
                        "detusulan.jmlh,\n" +
                        "barang.merk,\n" +
                        "barang.harga,\n" +
                        "barang.kode,\n" +
                        "detusulan.id\n" +
                        "FROM\n" +
                        "usulan\n" +
                        "INNER JOIN detusulan ON usulan.id = detusulan.idUsulan\n" +
                        "INNER JOIN barang ON detusulan.idBarang = barang.id\n" +
                        "WHERE\n" +
                        "usulan.id = " + idUsulan + " and usulan.status = 1 and detusulan.status = 1";

            MySqlDataReader reader = _connect.Reading(_sqlQuery, _connection,
                ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (reader.HasRows)
            {
                int noUrut = 1;
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(noUrut++.ToString());
                    items.SubItems.Add(reader[0].ToString());
                    items.SubItems.Add(reader[1].ToString());
                    items.SubItems.Add(reader[2].ToString());
                    items.SubItems.Add(reader[3].ToString());
                    items.SubItems.Add(reader[4].ToString());
                    items.SubItems.Add(reader[5].ToString());
                    _listViewItemsDetail.Add(items);
                }
                reader.Close();
                lvDetail.BeginUpdate();
                lvDetail.Items.Clear();
                lvDetail.Items.AddRange(_listViewItemsDetail.ToArray());
                lvDetail.EndUpdate();
            }
            else
            {
                lvDetail.Items.Clear();
            }
            _connection.Close();
        }

        private int _idJurusanMutasi;
        private void lvDaftar_MouseClick(object sender, MouseEventArgs e)
        {
            _idJurusanMutasi = Convert.ToInt16(lvDaftar.SelectedItems[0].SubItems[4].Text);
            RefreshLvDetail(lvDaftar.SelectedItems[0].SubItems[3].Text);
        }


        private int _idDetailUsulan;
        private int _nilaiAwal;
        private void lvDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // tambahkan ke tabel activity
            // ubah langsung tabel detail usulan
            _idDetailUsulan = Convert.ToInt16(lvDetail.SelectedItems[0].SubItems[6].Text);
            _nilaiAwal = Convert.ToInt16(lvDetail.SelectedItems[0].SubItems[2].Text);
            panelPop.Visible = true;
            textBox1.Text = lvDetail.SelectedItems[0].SubItems[2].Text;
        }

        private int GetMaxId(MySqlConnection connection, string query, ref string errMsg)
        {
            MySqlDataReader reader = _connect.Reading(query, connection, ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return -1;
            }

            if (reader.HasRows)
            {
                reader.Read();
                int returnValue = Convert.ToInt16(reader[0].ToString());
                reader.Close();
                return returnValue;
            }
            reader.Close();
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPop.Visible = false;
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            MySqlTransaction sqLiteTransaction = _connection.BeginTransaction();

            string asdasd = "SELECT \n" +
                            "COALESCE(Max(activity_log.id),0)\n" +
                            "FROM\n" +
                            "activity_log";
            int maxIdActivity = GetMaxId(_connection, asdasd, ref errMsg) + 1;

            _sqlQuery = "update detusulan set detusulan.jmlh = " + textBox1.Text + " where detusulan.id = " +
                        _idDetailUsulan + "";
            _connect.Insertion(_sqlQuery, _connection, sqLiteTransaction, ref errMsg);
            _sqlQuery = "insert into lab_inventory.activity_log values (" + maxIdActivity + ", 'detusulan', " +
                        _idDetailUsulan + ", 'detusulan.jmlh', '" + _nilaiAwal + "', '" + textBox1.Text + "', NOW(), " +
                        fUtama.IdUser + ")";
            _connect.Insertion(_sqlQuery, _connection, sqLiteTransaction, ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                sqLiteTransaction.Rollback();
                _connection.Close();
                return;
            }

            sqLiteTransaction.Commit();
            _connection.Close();

            RefreshLvDetail(lvDaftar.SelectedItems[0].SubItems[3].Text);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            MySqlTransaction sqLiteTransaction = _connection.BeginTransaction();

            string asdasd = "SELECT \n" +
                            "COALESCE(Max(mutasi.id),0)\n" +
                            "FROM\n" +
                            "mutasi";
            int maxIdMutasi = GetMaxId(_connection, asdasd, ref errMsg);

            foreach (ListViewItem item in lvDetail.Items)
            {
                maxIdMutasi++;
                _sqlQuery = "insert into lab_inventory.mutasi (id, tglMutasi, sisa, mutasi, status, idBarang, " +
                            "idUser, idJurusan, idDetUsulan) values (" + maxIdMutasi + ", NOW(), 0, " +
                            Convert.ToInt16(item.SubItems[2].Text) + ", 1, " +
                            Convert.ToInt16(item.SubItems[5].Text) + ", " + fUtama.IdUser + ", " +
                            _idJurusanMutasi + ", " + Convert.ToInt16(item.SubItems[6].Text) + ")";
                _connect.Insertion(_sqlQuery, _connection, sqLiteTransaction, ref errMsg);
                //int negInt = -System.Math.Abs(myInt) -> convert to negative value
            }

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                sqLiteTransaction.Rollback();
                _connection.Close();
                return;
            }

            sqLiteTransaction.Commit();
            _connection.Close();
        }
    }
}
