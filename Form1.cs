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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            bunifuCircleProgress1.Value = startpoint;
            if (bunifuCircleProgress1.Value == 100)
            {
                bunifuCircleProgress1.Value = 0;
                timer1.Stop();
                loginForm mylogin = new loginForm();
                this.Hide();
                mylogin.Show();
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
