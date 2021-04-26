using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class FormHalamanUtama : Form
    {
        public FormHalamanUtama()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Logout?", "Logout" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString();
        }

        private void kamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Daftar Kamar")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FormDaftarKamar fdk = new FormDaftarKamar();
                fdk.MdiParent = this;
                fdk.Show();
            }
        }

        private void FormHalamanUtama_Load(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Daftar Customer")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                DaftarCustomer dc = new DaftarCustomer();
                dc.MdiParent = this;
                dc.Show();
            }
        }

        private void pemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Booking")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Booking bk = new Booking();
                bk.MdiParent = this;
                bk.Show();
            }
        }

        private void pembatalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Pembatalan")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Pembatalan pb = new Pembatalan();
                pb.MdiParent = this;
                pb.Show();
            }
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Daftar Booking")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                DaftarBooking db = new DaftarBooking();
                db.MdiParent = this;
                db.Show();
            }
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Check In")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                CheckIn ci = new CheckIn();
                ci.MdiParent = this;
                ci.Show();
            }
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Check Out")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                CheckOut co = new CheckOut();
                co.MdiParent = this;
                co.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
