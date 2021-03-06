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
    public partial class FormAllProducts : Form
    {
        private MainMenu mainMenu;
        private string[,] barang = {
            {
                "Ayam Schnitzel", "Makanan", "16000"
            },
            {
                "Baju Dues", "Baju", "100000"
            },
            {
                "Earphone JBL", "Elektronik", "200000"
            },
            {
                "Kopikap", "Makanan", "1000"
            },
            {
                "Appel Watch", "Elektronik", "3000000"
            },
        };
        private System.Drawing.Image[] imgBarang = {
            global::TP1.Properties.Resources.schnitzel,
            global::TP1.Properties.Resources.deus,
            global::TP1.Properties.Resources.jbl,
            global::TP1.Properties.Resources.kopikap,
            global::TP1.Properties.Resources.appleWatch,
        };
        private Barang[] dataBarang;
        public FormAllProducts(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.dataBarang = new Barang[this.barang.GetLength(0)];
            Console.WriteLine("Barang length : " + this.barang.GetLength(0) + "\n");
            int i = 0, j = 0;
            foreach(string element in this.barang)
            {
                if (i % 3 == 0)
                {
                    this.dataBarang[j] = new Barang();
                    this.dataBarang[j].namaBarang = element;
                    Console.WriteLine("S[" + j +"] :" + this.dataBarang[j].namaBarang);
                }
                if (i % 3 == 1)
                {
                    this.dataBarang[j].jenisBarang = element;
                    Console.WriteLine("S[" + j + "] :" + this.dataBarang[j].jenisBarang);
                }
                if (i % 3 == 2) {
                    this.dataBarang[j].hargaBarang = Convert.ToInt32(element);
                    Console.WriteLine("S[" + j + "] :" + this.dataBarang[j].hargaBarang);
                    this.MainPanel.Controls.Add(new ProductData(this.mainMenu ,this.dataBarang[j].namaBarang, element, this.imgBarang[j]));
                    j++;
                }
                i++;
            }
            //this.MainPanel.Controls.Add(new ProductData());
        }

        private void addAll()
        {
            for (int i = 0; i < this.dataBarang.GetLength(0); i++)
            {
                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
            }
        }

        public void showFiltered(object cbJenis, object cbRange)
        {
            this.MainPanel.Controls.Clear();
            if(cbJenis == null && cbRange == null)
            {
                addAll();
            }
            else
            {
                if (cbJenis == null && cbRange != null)
                {
                    string range = cbRange.ToString();
                    for (int i = 0; i < this.dataBarang.GetLength(0); i++)
                    {
                        //100rb - 200rb
                        //200rb - 500rb
                        //500rb - 1jt
                        if (
                            ( range == "100rb - 200rb" && this.dataBarang[i].hargaBarang >= 100000 && this.dataBarang[i].hargaBarang < 200000 ) ||
                            ( range == "200rb - 2500rb" && this.dataBarang[i].hargaBarang >= 200000 && this.dataBarang[i].hargaBarang < 500000 ) ||
                            ( range == "500rb - 200jt" && this.dataBarang[i].hargaBarang >= 500000 && this.dataBarang[i].hargaBarang < 1000000)
                            )
                        {
                            this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                        }
                    }
                }
                else if(cbJenis != null && cbRange == null)
                {
                    string jenis = cbJenis.ToString();
                    for (int i = 0; i < this.dataBarang.GetLength(0); i++)
                    {
                        //Elektronik
                        //Baju
                        //Makanan
                        if (
                            (jenis == "Elektronik" && this.dataBarang[i].jenisBarang == "Elektronik") ||
                            (jenis == "Baju" && this.dataBarang[i].jenisBarang == "Baju") ||
                            (jenis == "Makanan" && this.dataBarang[i].jenisBarang == "Makanan")
                            )
                        {
                            this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                        }
                    }
                }
                else
                {
                    string jenis = cbJenis.ToString();
                    string range = cbRange.ToString();
                    for (int i = 0; i < this.dataBarang.GetLength(0); i++)
                    {
                        if (jenis == "Elektronik" && this.dataBarang[i].jenisBarang == "Elektronik")
                        {
                            if (range == "100rb - 200rb" && this.dataBarang[i].hargaBarang >= 100000 && this.dataBarang[i].hargaBarang < 200000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "200rb - 2500rb" && this.dataBarang[i].hargaBarang >= 200000 && this.dataBarang[i].hargaBarang < 500000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "500rb - 200jt" && this.dataBarang[i].hargaBarang >= 500000 && this.dataBarang[i].hargaBarang < 1000000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                        }
                        else if (jenis == "Baju" && this.dataBarang[i].jenisBarang == "Baju")
                        {
                            if (range == "100rb - 200rb" && this.dataBarang[i].hargaBarang >= 100000 && this.dataBarang[i].hargaBarang < 200000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "200rb - 2500rb" && this.dataBarang[i].hargaBarang >= 200000 && this.dataBarang[i].hargaBarang < 500000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "500rb - 200jt" && this.dataBarang[i].hargaBarang >= 500000 && this.dataBarang[i].hargaBarang < 1000000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                        }
                        else if (jenis == "Makanan" && this.dataBarang[i].jenisBarang == "Makanan")
                        {
                            if (range == "100rb - 200rb" && this.dataBarang[i].hargaBarang >= 100000 && this.dataBarang[i].hargaBarang < 200000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "200rb - 2500rb" && this.dataBarang[i].hargaBarang >= 200000 && this.dataBarang[i].hargaBarang < 500000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                            else if (range == "500rb - 200jt" && this.dataBarang[i].hargaBarang >= 500000 && this.dataBarang[i].hargaBarang < 1000000)
                            {
                                this.MainPanel.Controls.Add(new ProductData(this.mainMenu, this.dataBarang[i].namaBarang, this.dataBarang[i].hargaBarang.ToString(), this.imgBarang[i]));
                            }
                        }
                    }
                }
            }

        }

        public void setHeader(string text)
        {
            this.lbl_Header.Text = text;
        }
    }
}
