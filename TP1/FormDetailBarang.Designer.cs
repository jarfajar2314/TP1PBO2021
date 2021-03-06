
namespace TP1
{
    partial class FormDetailBarang
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
            this.lbl_DetailProducts = new System.Windows.Forms.Label();
            this.lbl_hargaBarang = new System.Windows.Forms.Label();
            this.lbl_barang = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.picBarang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DetailProducts
            // 
            this.lbl_DetailProducts.AutoSize = true;
            this.lbl_DetailProducts.Location = new System.Drawing.Point(27, 29);
            this.lbl_DetailProducts.Name = "lbl_DetailProducts";
            this.lbl_DetailProducts.Size = new System.Drawing.Size(77, 13);
            this.lbl_DetailProducts.TabIndex = 1;
            this.lbl_DetailProducts.Text = "Detail Produk :";
            // 
            // lbl_hargaBarang
            // 
            this.lbl_hargaBarang.Location = new System.Drawing.Point(168, 194);
            this.lbl_hargaBarang.Name = "lbl_hargaBarang";
            this.lbl_hargaBarang.Size = new System.Drawing.Size(170, 22);
            this.lbl_hargaBarang.TabIndex = 7;
            this.lbl_hargaBarang.Text = "Rp. 16.000,-";
            this.lbl_hargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_barang
            // 
            this.lbl_barang.Location = new System.Drawing.Point(210, 175);
            this.lbl_barang.Name = "lbl_barang";
            this.lbl_barang.Size = new System.Drawing.Size(92, 13);
            this.lbl_barang.TabIndex = 6;
            this.lbl_barang.Text = "Chicken Schnitzel";
            this.lbl_barang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(213, 223);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(82, 23);
            this.btn_buy.TabIndex = 8;
            this.btn_buy.Text = "Beli";
            this.btn_buy.UseVisualStyleBackColor = true;
            // 
            // picBarang
            // 
            this.picBarang.Image = global::TP1.Properties.Resources.PNB_co;
            this.picBarang.Location = new System.Drawing.Point(200, 55);
            this.picBarang.Name = "picBarang";
            this.picBarang.Size = new System.Drawing.Size(110, 106);
            this.picBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBarang.TabIndex = 5;
            this.picBarang.TabStop = false;
            // 
            // FormDetailBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 291);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.picBarang);
            this.Controls.Add(this.lbl_barang);
            this.Controls.Add(this.lbl_hargaBarang);
            this.Controls.Add(this.lbl_DetailProducts);
            this.Name = "FormDetailBarang";
            this.Text = "FormDetailBarang";
            ((System.ComponentModel.ISupportInitialize)(this.picBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DetailProducts;
        private System.Windows.Forms.Label lbl_hargaBarang;
        private System.Windows.Forms.Label lbl_barang;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.PictureBox picBarang;
    }
}