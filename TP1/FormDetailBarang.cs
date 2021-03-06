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
    public partial class FormDetailBarang : Form
    {
        public FormDetailBarang(string namaBarang, string hargaBarang, System.Drawing.Image imgBarang)
        {
            InitializeComponent();
            setDetailBarang(namaBarang, hargaBarang, imgBarang);
        }

        private void setDetailBarang(string namaBarang, string hargaBarang, System.Drawing.Image imgBarang)
        {
            this.lbl_barang.Text = namaBarang;
            this.lbl_hargaBarang.Text = "Rp. " + hargaBarang;
            this.picBarang.Image = imgBarang;
        }
    }
}
