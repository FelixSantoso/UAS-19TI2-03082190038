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
    public partial class DaftarCustomer : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable(); 

        public DaftarCustomer()
        {
            InitializeComponent();
        }

        private void DaftarCustomer_Load(object sender, EventArgs e)
        {
            loadDataCustomer();
        }

        private void populate(Customer obj)
        {
            dgvCustomer.Rows.Add(obj.Nama, obj.JenisIdentitas, obj.Identitas);
        }

        private void loadDataCustomer()
        {
            dgvCustomer.Rows.Clear();
            try
            {
                String sql = "select * FROM Customer";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Customer obj = new Customer();
                    obj.Nama = row[0].ToString();
                    obj.JenisIdentitas = row[1].ToString();
                    obj.Identitas = row[2].ToString();
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

        private void CariCustomer()
        {
            dgvCustomer.Rows.Clear();
            try
            {
                String sql = "select * FROM Customer where nama & jenis_identitas & identitas like '%"+txtCari.Text.Trim()+"%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Customer obj = new Customer();
                    obj.Nama = row[0].ToString();
                    obj.JenisIdentitas = row[1].ToString();
                    obj.Identitas = row[2].ToString();
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CariCustomer();
            }
        }
    }
}
