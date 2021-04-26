using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OleDb;
using Hotel.Model;
using Hotel.UI;


namespace Hotel

{
    public partial class Login : Form
    {
        private const string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=D:/Group PPL/Hotel/DB/Hotel.accdb;Persist Security Info = False";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable(); 

        public Login()
        {
            InitializeComponent();
        }

        private User check(string userID)
        {
            User pass = new User();
            try
            {
                String sql = "SELECT * FROM [User] WHERE User_ID = '" + userID + "'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    pass.UserID = row[0].ToString();
                    pass.Password = row[1].ToString();
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
            return pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToLower() == "admin" && txtPass.Text.ToLower() == "admin")
            {
                DaftarUser du = new DaftarUser();
                du.Show();
                this.Hide();
            }
            else
            {
                User pass = check(txtUser.Text.Trim());
                if (txtPass.Text == pass.Password)
                {
                    MessageBox.Show("Berhasil Login");
                    FormHalamanUtama fhu = new FormHalamanUtama();
                    this.Hide();
                    fhu.Show();
                }
                else
                {
                    MessageBox.Show("User/Password Invalid", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
   
        }

        private void Login_load(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0,0);
            this.Size = new Size(w, h);
        }
    }
}
