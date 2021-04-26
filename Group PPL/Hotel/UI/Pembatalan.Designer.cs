namespace Hotel.UI
{
    partial class Pembatalan
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipe = new System.Windows.Forms.TextBox();
            this.txtTipeBed = new System.Windows.Forms.TextBox();
            this.txtLantai = new System.Windows.Forms.TextBox();
            this.txtNoKamar = new System.Windows.Forms.TextBox();
            this.txtExtraBed = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtIdentitas = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblIdx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AllowUserToResizeColumns = false;
            this.dgvBooking.AllowUserToResizeRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBooking.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvBooking.Location = new System.Drawing.Point(-2, 117);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.Size = new System.Drawing.Size(701, 233);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Tipe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Tipe Bed";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Lantai";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 61;
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
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Identitas";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 72;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 62;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(63, 380);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(204, 20);
            this.txtCari.TabIndex = 2;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipe Bed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lantai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "No Kamar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Extra Bed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Identitas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status";
            // 
            // txtTipe
            // 
            this.txtTipe.Enabled = false;
            this.txtTipe.Location = new System.Drawing.Point(91, 6);
            this.txtTipe.Name = "txtTipe";
            this.txtTipe.Size = new System.Drawing.Size(190, 20);
            this.txtTipe.TabIndex = 12;
            // 
            // txtTipeBed
            // 
            this.txtTipeBed.Enabled = false;
            this.txtTipeBed.Location = new System.Drawing.Point(91, 32);
            this.txtTipeBed.Name = "txtTipeBed";
            this.txtTipeBed.Size = new System.Drawing.Size(190, 20);
            this.txtTipeBed.TabIndex = 13;
            // 
            // txtLantai
            // 
            this.txtLantai.Enabled = false;
            this.txtLantai.Location = new System.Drawing.Point(91, 56);
            this.txtLantai.Name = "txtLantai";
            this.txtLantai.Size = new System.Drawing.Size(190, 20);
            this.txtLantai.TabIndex = 14;
            // 
            // txtNoKamar
            // 
            this.txtNoKamar.Enabled = false;
            this.txtNoKamar.Location = new System.Drawing.Point(91, 79);
            this.txtNoKamar.Name = "txtNoKamar";
            this.txtNoKamar.Size = new System.Drawing.Size(190, 20);
            this.txtNoKamar.TabIndex = 15;
            // 
            // txtExtraBed
            // 
            this.txtExtraBed.Enabled = false;
            this.txtExtraBed.Location = new System.Drawing.Point(371, 6);
            this.txtExtraBed.Name = "txtExtraBed";
            this.txtExtraBed.Size = new System.Drawing.Size(207, 20);
            this.txtExtraBed.TabIndex = 16;
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(371, 32);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(207, 20);
            this.txtHarga.TabIndex = 17;
            // 
            // txtIdentitas
            // 
            this.txtIdentitas.Enabled = false;
            this.txtIdentitas.Location = new System.Drawing.Point(371, 56);
            this.txtIdentitas.Name = "txtIdentitas";
            this.txtIdentitas.Size = new System.Drawing.Size(207, 20);
            this.txtIdentitas.TabIndex = 18;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(371, 79);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(207, 20);
            this.txtStatus.TabIndex = 19;
            // 
            // lblIdx
            // 
            this.lblIdx.AutoSize = true;
            this.lblIdx.Location = new System.Drawing.Point(12, 128);
            this.lblIdx.Name = "lblIdx";
            this.lblIdx.Size = new System.Drawing.Size(0, 13);
            this.lblIdx.TabIndex = 20;
            this.lblIdx.Visible = false;
            // 
            // Pembatalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 405);
            this.Controls.Add(this.lblIdx);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdentitas);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtExtraBed);
            this.Controls.Add(this.txtNoKamar);
            this.Controls.Add(this.txtLantai);
            this.Controls.Add(this.txtTipeBed);
            this.Controls.Add(this.txtTipe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pembatalan";
            this.Text = "Pembatalan";
            this.Load += new System.EventHandler(this.Pembatalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipe;
        private System.Windows.Forms.TextBox txtTipeBed;
        private System.Windows.Forms.TextBox txtLantai;
        private System.Windows.Forms.TextBox txtNoKamar;
        private System.Windows.Forms.TextBox txtExtraBed;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtIdentitas;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblIdx;
    }
}