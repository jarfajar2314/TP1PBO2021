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
    public partial class Form1 : Form
    {
        public MainMenu mainMenuWin = new MainMenu();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Redirect to home page
            string username = Convert.ToString(tb_username.Text);
            string password = Convert.ToString(tb_password.Text);
            string pass = "pbo123";

            if(password != pass)
            {
                // Show Message Box
                string message = "Incorrect Password! Please re-check your password.";
                MessageBox.Show(message);
            }
            else
            {
                // Hide Login Form
                this.Hide();

                // Open Main Menu Form
                mainMenuWin.ShowDialog();
            }
        }
    }
}
