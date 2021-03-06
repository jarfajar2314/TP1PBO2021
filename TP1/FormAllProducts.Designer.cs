
namespace TP1
{
    partial class FormAllProducts
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
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainPanel.Size = new System.Drawing.Size(522, 291);
            this.MainPanel.TabIndex = 5;
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.lbl_Header);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(522, 26);
            this.panel_Header.TabIndex = 6;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Location = new System.Drawing.Point(13, 6);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(77, 13);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Semua Barang";
            // 
            // FormAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 291);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.MainPanel);
            this.Name = "FormAllProducts";
            this.Text = "FormAllProducts";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_Header;
    }
}