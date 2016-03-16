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
using _encryption;

namespace lab_inventory.Menu
{
    public partial class fLogin : Form
    {
        #region KOMPONEN WAJIB
        readonly CConnection _connect = new CConnection();
        private MySqlConnection _connection;
        private string _sqlQuery;
        private readonly string _configurationManager = Properties.Settings.Default.Setting;
        #endregion

        private fUtama _utama;

        public fLogin()
        {
            InitializeComponent();
        }

        private Form FormSudahDibuat(Type tipeForm)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(formTerbuat => formTerbuat.GetType() == tipeForm);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string errMsg = "";

            _connection = _connect.Connect(_configurationManager, ref errMsg, "123");
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            _sqlQuery = "SELECT pengguna.nama, pengguna.nip, pengguna.password, pengguna.id FROM pengguna where pengguna.userName = '" + txtNama.Text + "'";

            MySqlDataReader reader = _connect.Reading(_sqlQuery, _connection,
                ref errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (reader.HasRows)
            {
                reader.Read();
                if (CStringCipher.Decrypt(reader[2].ToString(), "123") == txtPass.Text)
                {
                    if ((_utama = (fUtama) FormSudahDibuat(typeof (fUtama))) == null)
                    {
                        _utama = new fUtama();
                        //System.Windows.Forms.ListView lvTampil = (System.Windows.Forms.ListView)cari.Controls["groupBox1"].Controls["lvTampil"];
                        //fillTheSearchTable(lvTampil);
                        //_utama.idOpp = Convert.ToInt16(txtkd_Pos.Text);
                        //_utama.Size = new System.Drawing.Size(_lebarLayar, _tinggiLayar);
                        _utama.StartPosition = FormStartPosition.CenterScreen;
                        //_utama.MdiParent = this;
                        _utama.Show();
                        Close();
                    }
                    else
                    {
                        //System.Windows.Forms.ListView lvTampil = (System.Windows.Forms.ListView)cari.Controls["groupBox1"].Controls["lvTampil"];
                        //fillTheSearchTable(lvTampil);
                        //_utama.idOpp = Convert.ToInt16(txtkd_Pos.Text);
                        _utama.SetUser(reader[0] + " .|. " + reader[1], Convert.ToInt16(reader[3]));
                        _utama.StatusLogin = true;
                        _utama.Select();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Pengguna atau Password tidak cocok!");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Pengguna atau Password tidak cocok!");
            }
            _connection.Close();
        }
    }
}
