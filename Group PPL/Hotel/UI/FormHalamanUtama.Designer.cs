namespace Hotel.UI
{
    partial class FormHalamanUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daftarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembatalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // daftarToolStripMenuItem
            // 
            this.daftarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kamarToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.bookingToolStripMenuItem});
            this.daftarToolStripMenuItem.Name = "daftarToolStripMenuItem";
            this.daftarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.daftarToolStripMenuItem.Text = "Daftar";
            // 
            // kamarToolStripMenuItem
            // 
            this.kamarToolStripMenuItem.Name = "kamarToolStripMenuItem";
            this.kamarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kamarToolStripMenuItem.Text = "Kamar";
            this.kamarToolStripMenuItem.Click += new System.EventHandler(this.kamarToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pemesananToolStripMenuItem,
            this.pembatalanToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // pemesananToolStripMenuItem
            // 
            this.pemesananToolStripMenuItem.Name = "pemesananToolStripMenuItem";
            this.pemesananToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pemesananToolStripMenuItem.Text = "Booking";
            this.pemesananToolStripMenuItem.Click += new System.EventHandler(this.pemesananToolStripMenuItem_Click);
            // 
            // pembatalanToolStripMenuItem
            // 
            this.pembatalanToolStripMenuItem.Name = "pembatalanToolStripMenuItem";
            this.pembatalanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pembatalanToolStripMenuItem.Text = "Pembatalan";
            this.pembatalanToolStripMenuItem.Click += new System.EventHandler(this.pembatalanToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(429, 217);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 239);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(504, 23);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.TabStop = true;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 97;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormHalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHalamanUtama";
            this.Text = "FormHalamanUtama";
            this.Load += new System.EventHandler(this.FormHalamanUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembatalanToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;

    }
}