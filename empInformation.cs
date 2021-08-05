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
    public partial class empInformation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19B06RC;Initial Catalog=glowPharma;Integrated Security=True");
        public empInformation()
        {
            InitializeComponent();
        }
        public void populate()
        {
            con.Open();

            string myQuery = "select * from empInfo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dt = new DataSet();
            dataAdapter.Fill(dt);
            empDetails.ReadOnly = true;
            empDetails.DataSource = dt.Tables[0];
            con.Close();

        }
        private void medicineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void empAddBtn_Click(object sender, EventArgs e)
        {

            if (empID.Text == "" || empName.Text == "" || empPhone.Text==""||empSalary.Text==""|| empAge.Text==""||empSex.SelectedIndex==-1) 
            {
                MessageBox.Show("Please fill out all the data !!", "Missing data", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                clear();
            }
            else
            {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("INSERT INTO empInfo values('" + empID.Text + "','" + empName.Text + "','" + empSalary.Text + "','" + empAge.Text + "','" + empPhone.Text + "','" + empSex.SelectedItem.ToString() + "','" + empJoinDate.Value + "')", con);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Employee added successfully!");
                 con.Close();
                 populate();
            }
        }

        private void empInformation_Load(object sender, EventArgs e)
        {
            populate();
            
        }

        private void medDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void clear()
        {
            empID.Text = "";
            empName.Text = "";
            empSalary.Text = "";
            empAge.Text = "";
            empPhone.Text = "";
            empSex.Text = "";
        }

        private void clearEmp_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void empUpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string querry = "update empInfo set empName='" + empName.Text + "',empSalary='" + empSalary.Text + "',empAge='" + empAge.Text + "',empSex='" + empSex.Text + "',empPhone='"+empPhone.Text+"',empJoinDate='"+empJoinDate.Value+"' where empID='" + empID.Text + "';";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee info Updated successfully!!");
            con.Close();
            populate();
            clear();
        }

        private void empDeleteBtn_Click(object sender, EventArgs e)
        {
            if (empID.Text=="")
            {
                MessageBox.Show("Wrong Operation, select employee to be deleted!!", "Delete error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "delete from empInfo where empID='" + empID.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee information deleted Successfully!!");
                con.Close();
                populate();
                clear();
            }
        }

        private void empDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empID.Text = empDetails.SelectedRows[0].Cells[0].Value.ToString();
            empName.Text = empDetails.SelectedRows[0].Cells[1].Value.ToString();
            empSalary.Text = empDetails.SelectedRows[0].Cells[2].Value.ToString();
            empAge.Text = empDetails.SelectedRows[0].Cells[3].Value.ToString();
            empPhone.Text = empDetails.SelectedRows[0].Cells[4].Value.ToString();
            empSex.Text = empDetails.SelectedRows[0].Cells[5].Value.ToString();
            empJoinDate.Text = empDetails.SelectedRows[0].Cells[6].Value.ToString();
        }
        
        private void backEmpInfo_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
