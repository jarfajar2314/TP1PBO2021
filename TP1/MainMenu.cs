using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class MainMenu : Form
    {
        private Form activeForm;
        public MainMenu()
        {
            InitializeComponent();
            OpenChildForm(new FormAllProducts(this));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 loginWin = new Form1();
            loginWin.Show();
        }

        public void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_desktop.Controls.Add(childForm);
            this.panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public void showBackBtn(string set)
        {
            if(set == "Show")
            {
                this.dropdown_JenisBarang.Visible = false;
                this.dropdown_rangeHarga.Visible = false;
                this.btn_cari.Visible = false;
                this.btn_reset.Visible = false;
                this.btn_back.Visible = true;
            }
            else
            {
                this.dropdown_JenisBarang.Visible = true;
                this.dropdown_rangeHarga.Visible = true;
                this.btn_cari.Visible = true;
                this.btn_reset.Visible = true;
                this.btn_back.Visible = false;
            }
        }

        private void btn_catalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tokopedia.com");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAllProducts(this));
            if (this.btn_back.Visible == true) showBackBtn("Hide");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAllProducts(this));
            this.dropdown_JenisBarang.SelectedIndex = -1;
            this.dropdown_rangeHarga.SelectedIndex = -1;
            this.showBackBtn("Hide");
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            object cbJenis = dropdown_JenisBarang.SelectedItem;
            object cbRange = dropdown_rangeHarga.SelectedItem;
            if(cbJenis != null && cbRange != null)
            {
                string jenis = cbJenis.ToString();
                string range = cbRange.ToString();
                Console.WriteLine(jenis + range);
            }
            FormAllProducts allPr = new FormAllProducts(this);
            OpenChildForm(allPr);
            allPr.showFiltered(cbJenis, cbRange);
            allPr.setHeader("Cari Barang");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.dropdown_JenisBarang.SelectedIndex = -1;
            this.dropdown_rangeHarga.SelectedIndex = -1;
            FormAllProducts allPr = new FormAllProducts(this);
            OpenChildForm(allPr);
            allPr.setHeader("Semua Barang");
        }
    }
}
