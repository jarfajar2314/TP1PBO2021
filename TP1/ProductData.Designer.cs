
namespace TP1
{
    partial class ProductData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_namaBarang = new System.Windows.Forms.Label();
            this.lbl_hargaBarang = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.picBarang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_namaBarang
            // 
            this.lbl_namaBarang.Location = new System.Drawing.Point(0, 183);
            this.lbl_namaBarang.Name = "lbl_namaBarang";
            this.lbl_namaBarang.Size = new System.Drawing.Size(157, 23);
            this.lbl_namaBarang.TabIndex = 1;
            this.lbl_namaBarang.Text = "Nama Barang";
            this.lbl_namaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hargaBarang
            // 
            this.lbl_hargaBarang.Location = new System.Drawing.Point(0, 211);
            this.lbl_hargaBarang.Name = "lbl_hargaBarang";
            this.lbl_hargaBarang.Size = new System.Drawing.Size(157, 23);
            this.lbl_hargaBarang.TabIndex = 2;
            this.lbl_hargaBarang.Text = "Rp 1000000";
            this.lbl_hargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(42, 254);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 3;
            this.btn_buy.Text = "Beli";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // picBarang
            // 
            this.picBarang.Image = global::TP1.Properties.Resources.schnitzel;
            this.picBarang.Location = new System.Drawing.Point(11, 2);
            this.picBarang.Name = "picBarang";
            this.picBarang.Size = new System.Drawing.Size(135, 135);
            this.picBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBarang.TabIndex = 0;
            this.picBarang.TabStop = false;
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_hargaBarang);
            this.Controls.Add(this.lbl_namaBarang);
            this.Controls.Add(this.picBarang);
            this.Name = "ProductData";
            this.Size = new System.Drawing.Size(157, 301);
            ((System.ComponentModel.ISupportInitialize)(this.picBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBarang;
        private System.Windows.Forms.Label lbl_namaBarang;
        private System.Windows.Forms.Label lbl_hargaBarang;
        private System.Windows.Forms.Button btn_buy;
    }
}
