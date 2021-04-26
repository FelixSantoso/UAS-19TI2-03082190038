using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.UI
{
    public partial class FormDaftarKamar : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable(); 

        public FormDaftarKamar()
        {
            InitializeComponent();
        }

        private void FormDaftarKamar_Load(object sender, EventArgs e)
        {
            loadDataKamar();
        }

        private void populate(Kamar obj)
        {
            dgvKamar.Rows.Add(obj.NoKamar, obj.Tipe, obj.Lantai, obj.TipeBed, obj.Harga, obj.ExtraBed);
        }

        void loadDataKamar()
        {
            dgvKamar.Rows.Clear();
            try
            {
                String sql = "select * FROM Kamar";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Kamar obj = new Kamar();
                    obj.NoKamar = row[0].ToString();
                    obj.Tipe = row[1].ToString();
                    obj.Lantai = Int32.Parse(row[2].ToString());
                    obj.TipeBed = row[3].ToString();
                    obj.Harga = Int32.Parse(row[4].ToString());
                    obj.ExtraBed = Int32.Parse(row[5].ToString());
                    populate(obj);
                }
                dbConn.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        void CariKamar()
        {
            dgvKamar.Rows.Clear();
            try
            {
                String sql = "select * FROM Kamar where no_kamar & tipe & lantai & tipe_bed & harga & extra_bed like '%" + txtCari.Text.Trim() +"%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Kamar obj = new Kamar();
                    obj.NoKamar = row[0].ToString();
                    obj.Tipe = row[1].ToString();
                    obj.Lantai = Int32.Parse(row[2].ToString());
                    obj.TipeBed = row[3].ToString();
                    obj.Harga = Int32.Parse(row[4].ToString());
                    obj.ExtraBed = Int32.Parse(row[5].ToString());
                    populate(obj);
                }
                dbConn.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            CariKamar();
        }
    }
}
