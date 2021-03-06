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
    public partial class ProductData : UserControl
    {
        private string namaBarang;
        private string hargaBarang;
        private System.Drawing.Image imgBarang;
        private MainMenu mainMenu;
        public ProductData(MainMenu mainMenu, string namaBarang, string hargaBarang, System.Drawing.Image imgBarang)
        {
            InitializeComponent();
            this.namaBarang = namaBarang;
            this.hargaBarang = hargaBarang;
            this.imgBarang = imgBarang;
            this.mainMenu = mainMenu;
            setProductLbl();
        }

        private void setProductLbl()
        {
            this.lbl_namaBarang.Text = this.namaBarang;
            this.lbl_hargaBarang.Text = "Rp. " +  this.hargaBarang;
            this.picBarang.Image = this.imgBarang;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            FormDetailBarang detailBarang = new FormDetailBarang(this.namaBarang, this.hargaBarang, this.imgBarang);
            this.mainMenu.showBackBtn("Show");
            this.mainMenu.OpenChildForm(detailBarang);
        }
    }
}
