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
    public partial class CheckOut : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public CheckOut()
        {
            InitializeComponent();
        }

        private void dgvCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvCheckOut.Rows[e.RowIndex];
            lblIdx.Text = e.RowIndex.ToString();
            txtTipe.Text = baris.Cells[0].Value.ToString();
            txtTipeBed.Text = baris.Cells[1].Value.ToString();
            txtLantai.Text = baris.Cells[2].Value.ToString();
            txtNoKamar.Text = baris.Cells[3].Value.ToString();
            txtExtraBed.Text = baris.Cells[4].Value.ToString();
            txtHarga.Text = baris.Cells[5].Value.ToString();
            txtIdentitas.Text = baris.Cells[6].Value.ToString();
            txtStatus.Text = baris.Cells[7].Value.ToString();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cari();
        }

        private void populate(Book obj)
        {
            dgvCheckOut.Rows.Add(obj.Tipe, obj.TipeBed, obj.Lantai, obj.NoKamar, obj.ExtraBed, obj.Harga, obj.Identitas, obj.Status);
        }

        private void loadDataBooking()
        {
            dgvCheckOut.Rows.Clear();
            try
            {
                String sql = "select * FROM CheckIn";
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

        private void deleteCheckIn(Book obj)
        {
            string sql = "DELETE FROM CheckIn WHERE No_Kamar='" + obj.NoKamar + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { DeleteCommand = dbConn.CreateCommand() };

                adapter.DeleteCommand.CommandText = sql;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Check Out");
                }
                dbConn.Close();
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

        private void addHistory(Book obj)
        {
            const string sql = "insert into History(Tipe, Tipe_Bed, Lantai, No_Kamar, Extra_bed, Harga, Identitas, Status) values (@tipe, @tipeBed, @lantai, @noKamar, @extraBed, @harga, @identitas, @status)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@tipe", obj.Tipe);
            cmd.Parameters.AddWithValue("@tipeBed", obj.TipeBed);
            cmd.Parameters.AddWithValue("@lantai", obj.Lantai);
            cmd.Parameters.AddWithValue("@noKamar", obj.NoKamar);
            cmd.Parameters.AddWithValue("@extraBed", obj.ExtraBed);
            cmd.Parameters.AddWithValue("@harga", obj.Harga);
            cmd.Parameters.AddWithValue("@identitas", obj.Identitas);
            cmd.Parameters.AddWithValue("@status", obj.Status);
            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                }
                dbConn.Close();
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
            dgvCheckOut.Rows.Clear();
            try
            {
                String sql = "select * FROM CheckIn where tipe & tipe_bed & lantai & no_kamar & extra_bed & harga & identitas & status like '%" + txtCari.Text.Trim() + "%'";
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Check Out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Book obj = new Book();
                obj.Tipe = txtTipe.Text.Trim();
                obj.TipeBed = txtTipeBed.Text.Trim();
                obj.Lantai = Int32.Parse(txtLantai.Text.Trim());
                obj.NoKamar = txtNoKamar.Text.Trim();
                obj.ExtraBed = txtExtraBed.Text.Trim();
                obj.Harga = Int32.Parse(txtHarga.Text.Trim());
                obj.Identitas = txtIdentitas.Text.Trim();
                deleteCheckIn(obj);
                obj.Status = "Check Out";
                addHistory(obj);
                loadDataBooking();
            }
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
             loadDataBooking();
        }


    }
}
