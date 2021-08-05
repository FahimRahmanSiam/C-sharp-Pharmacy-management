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
    public partial class MedicineStock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19B06RC;Initial Catalog=glowPharma;Integrated Security=True");
        public MedicineStock()
        {
            InitializeComponent();
        }
        public void popuComboBox()
        {
            string query = "select comName from comInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("comName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comName.ValueMember = "comName";
                comName.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
            private void addBtn_Click(object sender, EventArgs e)
        {
            if (medicineName.Text == "" || buyingPrice.Text == "" || sellingPrice.Text == "" || quantity.Text == "" || comName.SelectedItem == null || comName.Text== "")
            {
                MessageBox.Show("Please fill out all the data !!","Missing data" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO medInfo values('" + medicineName.Text + "'," + buyingPrice.Text + "," + sellingPrice.Text + "," + quantity.Text + ",'" + dateMedicine.Value + "','" + comName.SelectedItem.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine added successfully!");
                con.Close();

                populate();
            }
        }

        private void buyingPrice_TextChanged(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            con.Open();

            string myQuery = "select * from medInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dt = new DataSet();
            dataAdapter.Fill(dt);
            medDetails.ReadOnly = true;
            medDetails.DataSource = dt.Tables[0];

            con.Close();

            
        }
        private void MedicineStock_Load(object sender, EventArgs e)
        {
            populate();
            popuComboBox();
        }

        private void medDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medicineName.Text = medDetails.SelectedRows[0].Cells[1].Value.ToString();
            buyingPrice.Text= medDetails.SelectedRows[0].Cells[2].Value.ToString();
            sellingPrice.Text= medDetails.SelectedRows[0].Cells[3].Value.ToString();
            quantity.Text= medDetails.SelectedRows[0].Cells[4].Value.ToString();
            dateMedicine.Text = medDetails.SelectedRows[0].Cells[5].Value.ToString();
            comName.Text = medDetails.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update medInfo set bPrice=" + buyingPrice.Text + ",sPrice=" + sellingPrice.Text + ",quantity=" + quantity.Text + ",expDate='" + dateMedicine.Value + "',company='" + comName.Text + "' where medName='" + medicineName.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine info Updated successfully!!");
            con.Close();
            populate();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (medicineName.Text == "")
            {
                MessageBox.Show("Wrong Operation, select medicine to be deleted!!", "Delete error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "delete from medInfo where medName='" + medicineName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine deleted Successfully!!");
                con.Close();
                populate();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            medicineName.Text = "";
            buyingPrice.Text = "";
            sellingPrice.Text = "";
            quantity.Text = "";
            comName.Text = "";
        }
        
        private void backMedStock_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
