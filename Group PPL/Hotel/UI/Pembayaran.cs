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
    public partial class Pembayaran : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public Pembayaran()
        {
            InitializeComponent();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            loadDataBooking();
        }

        private void populate(Bayar byr)
        {
            dgvPembayaran.Rows.Add(byr.Identitas, byr.Tipe, byr.Tipe, byr.NoKamar, byr.ExtraBed, byr.Harga);
        }

        private void loadDataBooking()
        {
            dgvPembayaran.Rows.Clear();
            try
            {
                String sql = "select * FROM Booking";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Bayar byr = new Bayar();
                    byr.Identitas = row[6].ToString();
                    byr.Tipe = row[0].ToString();
                    byr.TipeBed = row[1].ToString();
                    byr.NoKamar = row[3].ToString();
                    byr.ExtraBed = row[4].ToString();
                    byr.Harga = Int32.Parse(row[    5].ToString());
                    populate(byr);
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

        private void cbMetode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetode.Text.Trim() == "Debit" || cbMetode.Text.Trim() == "Kredit")
            {
                txtBank.Enabled = true;
                txtNo.Enabled = true;
            }
            else
            {
                txtBank.Enabled = false;
                txtNo.Enabled = false;
                txtBank.Text = txtNo.Text = string.Empty;
            }
        }

        private void deleteBooking(Book obj)
        {
            string sql = "DELETE FROM Booking WHERE No_Kamar='" + obj.NoKamar + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { DeleteCommand = dbConn.CreateCommand() };

                adapter.DeleteCommand.CommandText = sql;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Booking Canceled");
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

        private void addPembayaran(Bayar byr)
        {
            const string sql = "insert into Pembayaran(Identitas, Tipe, Tipe_Bed, No_Kamar, Extra_Bed, Harga, Metode, Bank, No_Rekening) values (@identitas, @tipe, @tipeBed, @noKamar, @extraBed, @harga, @metode, @bank, @no)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@identitas", byr.Identitas);
            cmd.Parameters.AddWithValue("@tipe", byr.Tipe);
            cmd.Parameters.AddWithValue("@tipeBed", byr.TipeBed);
            cmd.Parameters.AddWithValue("@noKamar", byr.NoKamar);
            cmd.Parameters.AddWithValue("@extraBed", byr.ExtraBed);
            cmd.Parameters.AddWithValue("@harga", byr.Harga);
            cmd.Parameters.AddWithValue("@metode", byr.Metode);
            cmd.Parameters.AddWithValue("@bank", byr.Bank);
            cmd.Parameters.AddWithValue("@no", byr.No);
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

        private void dgvPembayaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvPembayaran.Rows[e.RowIndex];
            lblIdx.Text = e.RowIndex.ToString();
            txtIdentitas.Text = baris.Cells[0].Value.ToString();
            txtTipe.Text = baris.Cells[1].Value.ToString();
            txtTipeBed.Text = baris.Cells[2].Value.ToString();
            txtNoKamar.Text = baris.Cells[3].Value.ToString();
            txtExtraBed.Text = baris.Cells[4].Value.ToString();
            txtHarga.Text = baris.Cells[5].Value.ToString();
        }

        private void byrButton_Click(object sender, EventArgs e)
        {
            if (txtNoKamar.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Booking");
                return;
            }
            if(cbMetode.Text.Trim() == "")
            {
                MessageBox.Show("Metode required");
            }
            else if (cbMetode.Text.Trim() != "")
            {
                if (txtBank.Enabled == true)
                {
                    if (txtBank.Text.Trim() == "")
                    {
                        MessageBox.Show("Nama Bank required");
                    }
                    else if (txtNo.Text.Trim() == "")
                    {
                        MessageBox.Show("No Rekening/Kartu required");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Pembayaran Sukses?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            try
                            {
                                Bayar byr = new Bayar();
                                byr.Identitas = txtIdentitas.Text.Trim();
                                byr.Tipe = txtTipe.Text.Trim();
                                byr.TipeBed = txtTipeBed.Text.Trim();
                                byr.NoKamar = txtNoKamar.Text.Trim();
                                byr.ExtraBed = txtExtraBed.Text.Trim();
                                byr.Harga = Int32.Parse(txtHarga.Text.Trim());
                                byr.Metode = cbMetode.Text.Trim();
                                byr.Bank = txtBank.Text.Trim();
                                byr.No = Int32.Parse(txtNo.Text.Trim());
                                addPembayaran(byr);
                                MessageBox.Show("Thankyou for coming and ENJOYYYY");
                                this.Hide();
                            }
                            catch(Exception)
                            {
                                MessageBox.Show("No Rekening/Kartu harus dalam bentuk angka");
                            }
                        }
                        else if (dr == DialogResult.No)
                        {
                            Book obj = new Book();
                            obj.NoKamar = txtNoKamar.Text.Trim();
                            deleteBooking(obj);
                            this.Hide();
                        }
                    }
                }
                else if (txtBank.Enabled == false)
                {
                    DialogResult dr = MessageBox.Show("Pembayaran Sukses?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Thankyou for coming and ENJOYYYY");
                        Bayar byr = new Bayar();
                        byr.Identitas = txtIdentitas.Text.Trim();
                        byr.Tipe = txtTipe.Text.Trim();
                        byr.TipeBed = txtTipeBed.Text.Trim();
                        byr.NoKamar = txtNoKamar.Text.Trim();
                        byr.ExtraBed = txtExtraBed.Text.Trim();
                        byr.Harga = Int32.Parse(txtHarga.Text.Trim());
                        byr.Metode = cbMetode.Text.Trim();
                        byr.Bank = "-";
                        byr.No = 0;
                        addPembayaran(byr);
                        this.Hide();
                    }
                    else if (dr == DialogResult.No)
                    {
                        Book obj = new Book();
                        obj.NoKamar = txtNoKamar.Text.Trim();
                        deleteBooking(obj);
                        this.Hide();
                    }
                }
            }
        }
    }
}
