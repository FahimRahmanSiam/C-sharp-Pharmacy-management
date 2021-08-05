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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        MedicineStock ms = new MedicineStock();
        companyInfo ci = new companyInfo();
        billing bl = new billing();
        empInformation em = new empInformation();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeMedicine_Click(object sender, EventArgs e)
        {
            ms.Show();
            this.Hide();
        }

        private void homeUser_Click(object sender, EventArgs e)
        {
            em.Show();
            this.Hide();
        }

        private void homeBills_Click(object sender, EventArgs e)
        {
            bl.Show();
            this.Hide();
        }

        private void homeCompany_Click(object sender, EventArgs e)
        {
            ci.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            loginForm lg = new loginForm();
            lg.Show();
            this.Hide();
        }
    }
}
