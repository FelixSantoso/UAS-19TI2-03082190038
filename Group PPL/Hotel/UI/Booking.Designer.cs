namespace Hotel.UI
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbExtraBed = new System.Windows.Forms.ComboBox();
            this.cbTipe = new System.Windows.Forms.ComboBox();
            this.cbTipeBed = new System.Windows.Forms.ComboBox();
            this.cbLantai = new System.Windows.Forms.ComboBox();
            this.txtNoKamar = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJenisIdentitas = new System.Windows.Forms.ComboBox();
            this.txtIdentitas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtWaktu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numJumlahHari = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahHari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe Bed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lantai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Kamar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Extra Bed";
            // 
            // cbExtraBed
            // 
            this.cbExtraBed.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbExtraBed.Location = new System.Drawing.Point(123, 153);
            this.cbExtraBed.Name = "cbExtraBed";
            this.cbExtraBed.Size = new System.Drawing.Size(65, 21);
            this.cbExtraBed.TabIndex = 4;
            this.cbExtraBed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbExtraBed_KeyPress);
            // 
            // cbTipe
            // 
            this.cbTipe.FormattingEnabled = true;
            this.cbTipe.Items.AddRange(new object[] {
            "Deluxe",
            "Suit",
            "Standard",
            "Superior",
            "Junior suit",
            "Presidental"});
            this.cbTipe.Location = new System.Drawing.Point(123, 31);
            this.cbTipe.Name = "cbTipe";
            this.cbTipe.Size = new System.Drawing.Size(121, 21);
            this.cbTipe.TabIndex = 0;
            // 
            // cbTipeBed
            // 
            this.cbTipeBed.FormattingEnabled = true;
            this.cbTipeBed.Items.AddRange(new object[] {
            "Single",
            "Twin",
            "Double"});
            this.cbTipeBed.Location = new System.Drawing.Point(123, 61);
            this.cbTipeBed.Name = "cbTipeBed";
            this.cbTipeBed.Size = new System.Drawing.Size(121, 21);
            this.cbTipeBed.TabIndex = 1;
            // 
            // cbLantai
            // 
            this.cbLantai.FormattingEnabled = true;
            this.cbLantai.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbLantai.Location = new System.Drawing.Point(123, 91);
            this.cbLantai.Name = "cbLantai";
            this.cbLantai.Size = new System.Drawing.Size(121, 21);
            this.cbLantai.TabIndex = 2;
            // 
            // txtNoKamar
            // 
            this.txtNoKamar.Location = new System.Drawing.Point(123, 123);
            this.txtNoKamar.Name = "txtNoKamar";
            this.txtNoKamar.Size = new System.Drawing.Size(100, 20);
            this.txtNoKamar.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(54, 216);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(468, 46);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jenis Identitas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Identitas";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(346, 31);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(176, 20);
            this.txtNama.TabIndex = 6;
            // 
            // cbJenisIdentitas
            // 
            this.cbJenisIdentitas.FormattingEnabled = true;
            this.cbJenisIdentitas.Items.AddRange(new object[] {
            "KTP",
            "Passport"});
            this.cbJenisIdentitas.Location = new System.Drawing.Point(346, 61);
            this.cbJenisIdentitas.Name = "cbJenisIdentitas";
            this.cbJenisIdentitas.Size = new System.Drawing.Size(94, 21);
            this.cbJenisIdentitas.TabIndex = 7;
            // 
            // txtIdentitas
            // 
            this.txtIdentitas.Location = new System.Drawing.Point(346, 91);
            this.txtIdentitas.Name = "txtIdentitas";
            this.txtIdentitas.Size = new System.Drawing.Size(176, 20);
            this.txtIdentitas.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(123, 182);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(121, 20);
            this.txtHarga.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tanggal";
            // 
            // txtTanggal
            // 
            this.txtTanggal.Enabled = false;
            this.txtTanggal.Location = new System.Drawing.Point(346, 123);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(176, 20);
            this.txtTanggal.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Waktu";
            // 
            // txtWaktu
            // 
            this.txtWaktu.Enabled = false;
            this.txtWaktu.Location = new System.Drawing.Point(346, 153);
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(176, 20);
            this.txtWaktu.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Jumlah Hari";
            // 
            // numJumlahHari
            // 
            this.numJumlahHari.Location = new System.Drawing.Point(344, 183);
            this.numJumlahHari.Name = "numJumlahHari";
            this.numJumlahHari.ReadOnly = true;
            this.numJumlahHari.Size = new System.Drawing.Size(50, 20);
            this.numJumlahHari.TabIndex = 10;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 274);
            this.Controls.Add(this.numJumlahHari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtWaktu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdentitas);
            this.Controls.Add(this.cbJenisIdentitas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNoKamar);
            this.Controls.Add(this.cbLantai);
            this.Controls.Add(this.cbTipeBed);
            this.Controls.Add(this.cbTipe);
            this.Controls.Add(this.cbExtraBed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahHari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbExtraBed;
        private System.Windows.Forms.ComboBox cbTipe;
        private System.Windows.Forms.ComboBox cbTipeBed;
        private System.Windows.Forms.ComboBox cbLantai;
        private System.Windows.Forms.TextBox txtNoKamar;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJenisIdentitas;
        private System.Windows.Forms.TextBox txtIdentitas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWaktu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numJumlahHari;
    }
}