
namespace TP1
{
    partial class MainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dropdown_JenisBarang = new System.Windows.Forms.ComboBox();
            this.dropdown_rangeHarga = new System.Windows.Forms.ComboBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_catalog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Catalog = new System.Windows.Forms.PictureBox();
            this.sidebarPanel.SuspendLayout();
            this.logo.SuspendLayout();
            this.navbarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "1901581";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "M. Fajar Yusuf F.";
            // 
            // dropdown_JenisBarang
            // 
            this.dropdown_JenisBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdown_JenisBarang.FormattingEnabled = true;
            this.dropdown_JenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.dropdown_JenisBarang.Location = new System.Drawing.Point(12, 95);
            this.dropdown_JenisBarang.Name = "dropdown_JenisBarang";
            this.dropdown_JenisBarang.Size = new System.Drawing.Size(94, 21);
            this.dropdown_JenisBarang.TabIndex = 7;
            this.dropdown_JenisBarang.Text = "Jenis Barang";
            this.dropdown_JenisBarang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dropdown_rangeHarga
            // 
            this.dropdown_rangeHarga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dropdown_rangeHarga.FormattingEnabled = true;
            this.dropdown_rangeHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.dropdown_rangeHarga.Location = new System.Drawing.Point(12, 141);
            this.dropdown_rangeHarga.Name = "dropdown_rangeHarga";
            this.dropdown_rangeHarga.Size = new System.Drawing.Size(94, 21);
            this.dropdown_rangeHarga.TabIndex = 7;
            this.dropdown_rangeHarga.Text = "Harga";
            this.dropdown_rangeHarga.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(12, 176);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 10;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sidebarPanel.Controls.Add(this.btn_reset);
            this.sidebarPanel.Controls.Add(this.btn_back);
            this.sidebarPanel.Controls.Add(this.logo);
            this.sidebarPanel.Controls.Add(this.dropdown_JenisBarang);
            this.sidebarPanel.Controls.Add(this.btn_cari);
            this.sidebarPanel.Controls.Add(this.dropdown_rangeHarga);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(158, 450);
            this.sidebarPanel.TabIndex = 11;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 95);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 21);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Kembali";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MidnightBlue;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Controls.Add(this.pic_logo);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(158, 70);
            this.logo.TabIndex = 0;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.navbarPanel.Controls.Add(this.pic_Catalog);
            this.navbarPanel.Controls.Add(this.pic_Home);
            this.navbarPanel.Controls.Add(this.btn_logout);
            this.navbarPanel.Controls.Add(this.btn_catalog);
            this.navbarPanel.Controls.Add(this.btn_home);
            this.navbarPanel.Controls.Add(this.panel1);
            this.navbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarPanel.Location = new System.Drawing.Point(158, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(642, 70);
            this.navbarPanel.TabIndex = 12;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(389, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 70);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_catalog
            // 
            this.btn_catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_catalog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_catalog.FlatAppearance.BorderSize = 0;
            this.btn_catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_catalog.ForeColor = System.Drawing.Color.White;
            this.btn_catalog.Location = new System.Drawing.Point(136, 0);
            this.btn_catalog.Name = "btn_catalog";
            this.btn_catalog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_catalog.Size = new System.Drawing.Size(136, 70);
            this.btn_catalog.TabIndex = 1;
            this.btn_catalog.Text = "Web Catalog";
            this.btn_catalog.UseVisualStyleBackColor = true;
            this.btn_catalog.Click += new System.EventHandler(this.btn_catalog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(464, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel_desktop
            // 
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(158, 70);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(642, 380);
            this.panel_desktop.TabIndex = 13;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 205);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(136, 70);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Image = global::TP1.Properties.Resources.PNB_co;
            this.pic_logo.Location = new System.Drawing.Point(9, 8);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Padding = new System.Windows.Forms.Padding(3);
            this.pic_logo.Size = new System.Drawing.Size(141, 54);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // pic_Home
            // 
            this.pic_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Home.Image = global::TP1.Properties.Resources.home;
            this.pic_Home.Location = new System.Drawing.Point(16, 20);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Padding = new System.Windows.Forms.Padding(3);
            this.pic_Home.Size = new System.Drawing.Size(27, 27);
            this.pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Home.TabIndex = 2;
            this.pic_Home.TabStop = false;
            // 
            // pic_Catalog
            // 
            this.pic_Catalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Catalog.Image = global::TP1.Properties.Resources.shopping;
            this.pic_Catalog.Location = new System.Drawing.Point(145, 20);
            this.pic_Catalog.Name = "pic_Catalog";
            this.pic_Catalog.Padding = new System.Windows.Forms.Padding(3);
            this.pic_Catalog.Size = new System.Drawing.Size(27, 27);
            this.pic_Catalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Catalog.TabIndex = 4;
            this.pic_Catalog.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.navbarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Catalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropdown_JenisBarang;
        private System.Windows.Forms.ComboBox dropdown_rangeHarga;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_catalog;
        private System.Windows.Forms.Panel panel_desktop;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox pic_Catalog;
        private System.Windows.Forms.PictureBox pic_Home;
    }
}