using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        public string namaBarang { get; set; }
        public string jenisBarang { get; set; }
        public int hargaBarang { get; set; }

        public string imgBarang { get; set; }

        public Barang()
        {

        }
        public Barang(string namaBarang, string jenisBarang, int hargaBarang)
        {
            this.namaBarang = namaBarang;
            this.jenisBarang = jenisBarang;
            this.hargaBarang = hargaBarang;
            //this.imgBarang = imgBarang;
        }
    }
}
