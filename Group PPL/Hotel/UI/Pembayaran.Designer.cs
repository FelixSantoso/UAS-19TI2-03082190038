namespace Hotel.UI
{
    partial class Pembayaran
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
            this.dgvPembayaran = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentitas = new System.Windows.Forms.TextBox();
            this.txtTipe = new System.Windows.Forms.TextBox();
            this.txtTipeBed = new System.Windows.Forms.TextBox();
            this.txtNoKamar = new System.Windows.Forms.TextBox();
            this.byrButton = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtExtraBed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.cbMetode = new System.Windows.Forms.ComboBox();
            this.lblIdx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPembayaran
            // 
            this.dgvPembayaran.AllowUserToAddRows = false;
            this.dgvPembayaran.AllowUserToDeleteRows = false;
            this.dgvPembayaran.AllowUserToResizeColumns = false;
            this.dgvPembayaran.AllowUserToResizeRows = false;
            this.dgvPembayaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPembayaran.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPembayaran.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembayaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPembayaran.Location = new System.Drawing.Point(12, 110);
            this.dgvPembayaran.Name = "dgvPembayaran";
            this.dgvPembayaran.ReadOnly = true;
            this.dgvPembayaran.Size = new System.Drawing.Size(540, 51);
            this.dgvPembayaran.TabIndex = 0;
            this.dgvPembayaran.TabStop = false;
            this.dgvPembayaran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembayaran_CellClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Identitas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Tipe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 53;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Tipe Bed";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "No Kamar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Extra Bed";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Harga";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipe Bed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No Kamar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Extra Bed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // txtIdentitas
            // 
            this.txtIdentitas.Enabled = false;
            this.txtIdentitas.Location = new System.Drawing.Point(97, 10);
            this.txtIdentitas.Name = "txtIdentitas";
            this.txtIdentitas.Size = new System.Drawing.Size(144, 20);
            this.txtIdentitas.TabIndex = 7;
            // 
            // txtTipe
            // 
            this.txtTipe.Enabled = false;
            this.txtTipe.Location = new System.Drawing.Point(97, 41);
            this.txtTipe.Name = "txtTipe";
            this.txtTipe.Size = new System.Drawing.Size(144, 20);
            this.txtTipe.TabIndex = 8;
            // 
            // txtTipeBed
            // 
            this.txtTipeBed.Enabled = false;
            this.txtTipeBed.Location = new System.Drawing.Point(97, 70);
            this.txtTipeBed.Name = "txtTipeBed";
            this.txtTipeBed.Size = new System.Drawing.Size(144, 20);
            this.txtTipeBed.TabIndex = 9;
            // 
            // txtNoKamar
            // 
            this.txtNoKamar.Enabled = false;
            this.txtNoKamar.Location = new System.Drawing.Point(325, 10);
            this.txtNoKamar.Name = "txtNoKamar";
            this.txtNoKamar.Size = new System.Drawing.Size(113, 20);
            this.txtNoKamar.TabIndex = 10;
            // 
            // byrButton
            // 
            this.byrButton.Location = new System.Drawing.Point(384, 167);
            this.byrButton.Name = "byrButton";
            this.byrButton.Size = new System.Drawing.Size(168, 80);
            this.byrButton.TabIndex = 3;
            this.byrButton.Text = "Done";
            this.byrButton.UseVisualStyleBackColor = true;
            this.byrButton.Click += new System.EventHandler(this.byrButton_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(325, 70);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(113, 20);
            this.txtHarga.TabIndex = 12;
            // 
            // txtExtraBed
            // 
            this.txtExtraBed.Enabled = false;
            this.txtExtraBed.Location = new System.Drawing.Point(325, 41);
            this.txtExtraBed.Name = "txtExtraBed";
            this.txtExtraBed.Size = new System.Drawing.Size(113, 20);
            this.txtExtraBed.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Metode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bank";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "No Rekening/Kartu";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(132, 231);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(229, 20);
            this.txtNo.TabIndex = 2;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(132, 204);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(162, 20);
            this.txtBank.TabIndex = 1;
            // 
            // cbMetode
            // 
            this.cbMetode.FormattingEnabled = true;
            this.cbMetode.Items.AddRange(new object[] {
            "Tunai",
            "Debit",
            "Kredit"});
            this.cbMetode.Location = new System.Drawing.Point(132, 174);
            this.cbMetode.Name = "cbMetode";
            this.cbMetode.Size = new System.Drawing.Size(162, 21);
            this.cbMetode.TabIndex = 0;
            this.cbMetode.SelectedIndexChanged += new System.EventHandler(this.cbMetode_SelectedIndexChanged);
            // 
            // lblIdx
            // 
            this.lblIdx.AutoSize = true;
            this.lblIdx.Location = new System.Drawing.Point(15, 90);
            this.lblIdx.Name = "lblIdx";
            this.lblIdx.Size = new System.Drawing.Size(41, 13);
            this.lblIdx.TabIndex = 20;
            this.lblIdx.Text = "label10";
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.ControlBox = false;
            this.Controls.Add(this.lblIdx);
            this.Controls.Add(this.cbMetode);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExtraBed);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.byrButton);
            this.Controls.Add(this.txtNoKamar);
            this.Controls.Add(this.txtTipeBed);
            this.Controls.Add(this.txtTipe);
            this.Controls.Add(this.txtIdentitas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPembayaran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pembayaran";
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentitas;
        private System.Windows.Forms.TextBox txtTipe;
        private System.Windows.Forms.TextBox txtTipeBed;
        private System.Windows.Forms.TextBox txtNoKamar;
        private System.Windows.Forms.Button byrButton;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtExtraBed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.ComboBox cbMetode;
        private System.Windows.Forms.Label lblIdx;
    }
}