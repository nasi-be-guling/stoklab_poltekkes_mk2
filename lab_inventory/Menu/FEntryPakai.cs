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
using OfficeOpenXml;
using System.IO;

namespace lab_inventory.Menu
{
    public partial class FEntryPakai : Form
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
        List<ListViewItem> _listViewItems = new List<ListViewItem>();

        public FEntryPakai()
        {
            InitializeComponent();
        }

        private void FEntryPakai_Load(object sender, EventArgs e)
        {
            Cleanse();
            SelectDataJurusan();
        }

        private void Cleanse()
        {
            lvTampil.Items.Clear();
            _listViewItems.Clear();
            txtFileName.Text = "";
            cbProdi.Text = "";
            lblKodeJurusan.Text = "";
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

        private void cbProdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbProdi_TextChanged(object sender, EventArgs e)
        {
            var query = (from i in _jurusans where i.Nama == cbProdi.Text select i);
            foreach (var item in query)
            {
                lblKodeJurusan.Text = item.Id + "-" + item.Kode;
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        private string ReadRecord(MySqlConnection connection, string query, ref string errMsg)
        {
            MySqlDataReader reader = _connect.Reading(query, connection, ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return null;
            }

            if (reader.HasRows)
            {
                reader.Read();
                string returnValue = reader[0].ToString();
                reader.Close();
                return returnValue;
            }
            reader.Close();
            return null;
        }

        private void bProses_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            //string query = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            lvTampil.Items.Clear();
            _listViewItems.Clear();
            var existingFile = new FileInfo(txtFileName.Text);
            // Open and read the XlSX file.
            try
            {
                using (var package = new ExcelPackage(existingFile))
                {
                    // Get the work book in the file
                    ExcelWorkbook workBook = package.Workbook;
                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            #region Read Sample
                            // Get the first worksheet
                            //ExcelWorksheet currentWorksheet = workBook.Worksheets.First();

                            // read some data
                            //textBox1.Text = currentWorksheet.Cells[1, 1].Text; 
                            #endregion

                            ExcelWorksheet worksheets = workBook.Worksheets[1];
                            int start = worksheets.Dimension.Start.Row;
                            int end = worksheets.Dimension.End.Row;
                            int noUrut = 1;
                            for (int row = start + 1; row <= end; row++)
                            {
                                ListViewItem item = new ListViewItem(noUrut++.ToString());
                                item.SubItems.Add(worksheets.Cells[row, 2].Text);
                                item.SubItems.Add(worksheets.Cells[row, 3].Text);
                                item.SubItems.Add(worksheets.Cells[row, 4].Text);
                                item.SubItems.Add(worksheets.Cells[row, 5].Text);
                                item.SubItems.Add(worksheets.Cells[row, 6].Text);
                                item.SubItems.Add(ReadRecord(_connection,
                                    "select barang.id_prodi from barang where lab_inventory.barang.kode = " +
                                    worksheets.Cells[row, 6].Text + " and barang.status = 1", ref errMsg));
                                item.SubItems.Add(ReadRecord(_connection,
                                    "SELECT\n" +
                                    "detusulan.idBarang\n" +
                                    "FROM\n" +
                                    "detusulan\n" +
                                    "WHERE\n" +
                                    "YEAR(detusulan.tgl) = YEAR(now()) AND\n" +
                                    "detusulan.idBarang = " +
                                    worksheets.Cells[row, 6].Text + " and detusulan.status = 1", ref errMsg));
                                _listViewItems.Add(item);
                            }

                            lvTampil.BeginUpdate();
                            lvTampil.Items.Clear();
                            lvTampil.Items.AddRange(_listViewItems.ToArray());
                            lvTampil.EndUpdate();
                            _connection.Close();
                        }
                    }
                    package.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format("Telah terjadi kesalahan {0} dgn kode: {1} {2}Sumber kode : {3}", "Pembacaan Excel",
                        ex.Message, Environment.NewLine, ex.Data), @"KESALAHAN");
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }
    }
}
