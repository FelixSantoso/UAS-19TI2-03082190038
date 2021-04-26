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
    public partial class DaftarUser : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable(); 

        public DaftarUser()
        {
            InitializeComponent();
        }

        private void DaftarUser_Load(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            loadDataUser();
        }

        private void populate(User pass)
        {
            dgvUser.Rows.Add(pass.UserID);
        }

        private void loadDataUser()
        {
            dgvUser.Rows.Clear();
            try
            {
                String sql = "select * FROM [User]";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    User pass = new User();
                    pass.UserID = row[0].ToString();
                    populate(pass);
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

        void CariUser()
        {
            dgvUser.Rows.Clear();
            try
            {
                String sql = "select * FROM [User] where user_id like '%" + txtCari.Text.Trim() + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    User pass = new User();
                    pass.UserID = row[0].ToString();
                    populate(pass);
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

        private void deleteUser(User pass)
        {
            string sql = "DELETE FROM [User] WHERE User_ID ='" + pass.UserID + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { DeleteCommand = dbConn.CreateCommand() };

                adapter.DeleteCommand.CommandText = sql;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Succeed");
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

        private void addUser(User pass)
        {
            const string sql = "insert into [User]([User_ID], [Password]) values (@userID, @password)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@userID", pass.UserID);
            cmd.Parameters.AddWithValue("@password", pass.Password);
            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Succeed");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvUser);
            row.Cells[0].Value = txtUser.Text.Trim().ToUpper(); ;
            dgvUser.Rows.Add(row);
            User pass = new User();
            pass.UserID = txtUser.Text.Trim().ToUpper();
            pass.Password = txtPass.Text.Trim().ToLower();
            addUser(pass);
            txtUser.Text = txtPass.Text = string.Empty;
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            CariUser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvUser.Rows[e.RowIndex];
            lblIdx.Text = e.RowIndex.ToString();
            txtUser.Text = baris.Cells[0].Value.ToString();
            txtPass.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User pass = new User();
            pass.UserID = txtUser.Text.Trim();
            deleteUser(pass);
            loadDataUser();
            txtUser.Text = txtPass.Text = string.Empty;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtPass.Enabled = true;
            }
        }


    }
}
