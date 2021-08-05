using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(userName.Text=="Fahim" && password.Text == "aspirine")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else if(userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Empty fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Invalid Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
