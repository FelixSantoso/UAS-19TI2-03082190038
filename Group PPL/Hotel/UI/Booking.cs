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
    public partial class Booking : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable(); 

        public Booking()
        {
            InitializeComponent();
        }

        private void addBooking(Book obj)
        {
            const string sql = "insert into Booking(Tipe, Tipe_Bed, Lantai, No_Kamar, Extra_bed, Harga, Identitas, Status, Tanggal, Waktu, Jumlah_Hari) values (@tipe, @tipeBed, @lantai, @noKamar, @extraBed, @harga, @identitas, @status, @tanggal, @waktu, @jumlahHari)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@tipe", obj.Tipe );
            cmd.Parameters.AddWithValue("@tipeBed", obj.TipeBed);
            cmd.Parameters.AddWithValue("@lantai", obj.Lantai);
            cmd.Parameters.AddWithValue("@noKamar", obj.NoKamar);
            cmd.Parameters.AddWithValue("@extraBed", obj.ExtraBed);
            cmd.Parameters.AddWithValue("@harga", obj.Harga);
            cmd.Parameters.AddWithValue("@identitas", obj.Identitas);
            cmd.Parameters.AddWithValue("@status", obj.Status);
            cmd.Parameters.AddWithValue("@tanggal", obj.Tanggal);
            cmd.Parameters.AddWithValue("@waktu", obj.Waktu);
            cmd.Parameters.AddWithValue("@jumlahHari", obj.JumlahHari);
            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kamar telah di booking");
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

        private void addCustomer(Customer objek)
        {
            const string sql = "insert into Customer(Nama, Jenis_Identitas, Identitas) values (@nama, @jenisIdentitas, @identitas)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@nama", objek.Nama);
            cmd.Parameters.AddWithValue("@jenisIdentitas", objek.JenisIdentitas);
            cmd.Parameters.AddWithValue("@identitas", objek.Identitas);

            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("New Data Customer");
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

        private Book checkKamar(string noKamar)
        {
            Book status = new Book();
            try
            {
                String sql = "SELECT * FROM [CheckIn] WHERE No_Kamar = '" + noKamar + "'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    status.NoKamar = row[3].ToString();
                    status.Status = row[7].ToString();
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
            return status;
        }

        //Mengecek apakah customer sudah pernah datang
        private Customer checkCustomer(string identitas)
        {
            Customer idt = new Customer();
            try
            {
                String sql = "SELECT * FROM Customer WHERE Identitas = '" + identitas + "'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    idt.Nama = row[0].ToString();
                    idt.JenisIdentitas = row[1].ToString();
                    idt.Identitas = row[2].ToString();
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
            return idt;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cbTipe.Text.Trim() == "")
            {
                MessageBox.Show("Tipe required");
            }
            else if (cbTipeBed.Text.Trim() == "")
            {
                MessageBox.Show("Tipe Bed required");
            }
            else if (cbLantai.Text.Trim() == "")
            {
                MessageBox.Show("Lantai required");
            }
            else if ( txtNoKamar.Text.Trim() == "")
            {
                MessageBox.Show("No Kamar required");
            }
            else if (cbExtraBed.Text.Trim() == "")
            {
                MessageBox.Show("Extra Bed required");
            }
            else if(txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Nama required");
            }
            else if (cbJenisIdentitas.Text.Trim() == "")
            {
                MessageBox.Show("Jenis Identitas required");
            }
            else if (txtIdentitas.Text.Trim() == "")
            {
                MessageBox.Show("Identitas required");
            }
            else if(txtHarga.Text.Trim() == "")
            {
                MessageBox.Show("Harga required");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Booking kamar?", "Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int harga = Int32.Parse(txtHarga.Text.Trim());
                        Book obj = new Book();
                        obj.Tipe = cbTipe.Text.Trim();
                        obj.TipeBed = cbTipeBed.Text.Trim();
                        obj.Lantai = Int32.Parse(cbLantai.Text.Trim());
                        obj.NoKamar = txtNoKamar.Text.Trim();
                        obj.ExtraBed = cbExtraBed.Text.Trim();
                        obj.Harga = Int32.Parse(txtHarga.Text.Trim());
                        obj.Identitas = txtIdentitas.Text.Trim();
                        obj.Status = "Unknown";
                        obj.Tanggal = txtTanggal.Text.Trim();
                        obj.Waktu = txtWaktu.Text.Trim();
                        obj.JumlahHari = Int32.Parse(numJumlahHari.Text.Trim());
                        addBooking(obj);

                        //Customer idt = checkCustomer(txtIdentitas.Text.Trim());
                        //if (txtNama.Text == idt.Nama)
                        //{
                        //    MessageBox.Show("Customer exist");
                        //}
                        Customer objek = new Customer();
                        objek.Nama = txtNama.Text.Trim();
                        objek.JenisIdentitas = cbJenisIdentitas.Text.Trim();
                        objek.Identitas = txtIdentitas.Text.Trim();
                        addCustomer(objek);
                        this.Hide();
                        Pembayaran pb = new Pembayaran();
                        pb.Show();
                    }   
                    catch(Exception)
                    {
                        MessageBox.Show("Input Error");
                    }
                }
            }
        }

        private Kamar getHarga(string noKamar)
        {
            Kamar obj = new Kamar();

            try
            {
                String sql = "SELECT * FROM Kamar where No_Kamar = '" + noKamar + "'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    obj.Harga = Int32.Parse(row[4].ToString());
                    obj.ExtraBed = Int32.Parse(row[5].ToString());
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
            return obj;
        }

        private void cbExtraBed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Kamar obj = getHarga(txtNoKamar.Text.Trim());
                if (cbExtraBed.Text.Trim().ToLower() == "no" )
                {
                    txtHarga.Text = obj.Harga.ToString();
                }
                else if (cbExtraBed.Text.Trim().ToLower() == "yes")
                {
                    txtHarga.Text = (obj.Harga + obj.ExtraBed).ToString();
                }
                else
                {
                    txtHarga.Text = "Extra Bed?";
                }
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTanggal.Text = DateTime.Now.ToLongDateString();
            txtWaktu.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
