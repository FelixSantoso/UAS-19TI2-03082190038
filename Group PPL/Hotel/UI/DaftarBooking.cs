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
    public partial class DaftarBooking : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public DaftarBooking()
        {
            InitializeComponent();
        }

        private void DaftarBooking_Load(object sender, EventArgs e)
        {
            loadDataHistory();
        }

        private void populate(Book obj)
        {
            dgvHistory.Rows.Add(obj.Tipe, obj.TipeBed, obj.Lantai, obj.NoKamar, obj.ExtraBed, obj.Harga, obj.Identitas, obj.Status);
        }

        private void loadDataHistory()
        {
            dgvHistory.Rows.Clear();
            try
            {
                String sql = "select * FROM History";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Book obj = new Book();
                    obj.Tipe = row[0].ToString();
                    obj.TipeBed = row[1].ToString();
                    obj.Lantai = Int32.Parse(row[2].ToString());
                    obj.NoKamar = row[3].ToString();
                    obj.ExtraBed = row[4].ToString();
                    obj.Harga = Int32.Parse(row[5].ToString());
                    obj.Identitas = row[6].ToString();
                    obj.Status = row[7].ToString();
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

        void Cari()
        {
            dgvHistory.Rows.Clear();
            try
            {
                String sql = "select * FROM History where tipe & tipe_bed & lantai & no_kamar & extra_bed & harga & identitas & status like '%" + txtCari.Text.Trim() + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Book obj = new Book();
                    obj.Tipe = row[0].ToString();
                    obj.TipeBed = row[1].ToString();
                    obj.Lantai = Int32.Parse(row[2].ToString());
                    obj.NoKamar = row[3].ToString();
                    obj.ExtraBed = row[4].ToString();
                    obj.Harga = Int32.Parse(row[5].ToString());
                    obj.Identitas = row[6].ToString();
                    obj.Status = row[7].ToString();
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cari();
            }
        }
    }
}
