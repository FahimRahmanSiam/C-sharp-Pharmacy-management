using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class companyInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19B06RC;Initial Catalog=glowPharma;Integrated Security=True");
        public companyInfo()
        {
            InitializeComponent();
        }
        public void populate()
        {
            con.Open();
            string myQuery = "select * from comInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dt = new DataSet();
            dataAdapter.Fill(dt);
            comDetails.ReadOnly = true;
            comDetails.DataSource = dt.Tables[0];
            con.Close();

        }
        private void clear()
        {
            comID.Text = "";
            comName.Text = "";
            comAddress.Text = "";
            comEmail.Text = "";
            comPhone.Text = "";
        }
            private void comAddBtn_Click(object sender, EventArgs e)
        {
            if (comID.Text == "" || comName.Text == "" || comAddress.Text == "" || comEmail.Text == "" || comPhone.Text == "")
            {
                MessageBox.Show("Please fill out all the data !!", "Missing data", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                clear();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO comInfo values('" + comID.Text + "','" + comName.Text + "','" + comAddress.Text + "','" + comEmail.Text + "','" + comPhone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company added successfully!");
                con.Close();
                populate();
            }
        }

        private void clearCom_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comDeleteBtn_Click(object sender, EventArgs e)
        {
            if (comID.Text == "")
            {
                MessageBox.Show("Wrong Operation, select employee to be deleted!!", "Delete error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                con.Open();
                string query = "delete from comInfo where comID='" + comID.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company information deleted Successfully!!");
                con.Close();
                populate();
                clear();
            }
        }

        private void comDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comID.Text = comDetails.SelectedRows[0].Cells[0].Value.ToString();
            comName.Text = comDetails.SelectedRows[0].Cells[1].Value.ToString();
            comAddress.Text = comDetails.SelectedRows[0].Cells[2].Value.ToString();
            comEmail.Text = comDetails.SelectedRows[0].Cells[3].Value.ToString();
            comPhone.Text = comDetails.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void comUpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string querry = "update comInfo set comName='" + comName.Text + "',comAddress='" + comAddress.Text + "',comEmail='" + comEmail.Text + "',comPhone='" + comPhone.Text + "' where comID='" + comID.Text + "';";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company info Updated successfully!!");
            con.Close();
            populate();
            clear();
        }

        private void companyInfo_Load(object sender, EventArgs e)
        {
            populate();
        }
        
        public void backComInfo_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
