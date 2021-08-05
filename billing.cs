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
    public partial class billing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19B06RC;Initial Catalog=glowPharma;Integrated Security=True");
        public billing()
        {
            InitializeComponent();
        }
        public void populateComboBox()
        {
            string query = "select * from medInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("medName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                billMedSelect.ValueMember = "medName";
                billMedSelect.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        int n = 0;
        private void billing_Load(object sender, EventArgs e)
        {
            populateComboBox();
            int n = 0;

        }

        private void billMedSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int x,unitP;
        public void fetchQty()
        {
            con.Open();
            string query = "select * from medInfo where medName='" + billMedSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["quantity"].ToString());
                unitP= Convert.ToInt32(dr["sPrice"].ToString());
                billMedAvailable.Text ="Available stock is "+dr["quantity"].ToString();
                billMedAvailable.Visible = true;
            }
            con.Close();
        }
        private void billMedSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }
        int grandTotal = 0;
        Bitmap bitmap;
        private void printBillBtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        public void medUpdate()
        {
            con.Open();
            int newQty = x - Convert.ToInt32(billMedQty.Text);
            string myQuery = "update medInfo set quantity='" + newQty + "' where medName='" + billMedSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            billMedAvailable.Text = "Available stock is "+newQty+"";
        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void billingAddBtn_Click(object sender, EventArgs e)
        {
            if (billMedQty.Text=="")
            {
                MessageBox.Show("Please fill out the Quantity !!", "Missing Quantity", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else if (Convert.ToInt32(billMedQty.Text)>x)
            {
                MessageBox.Show("Quantity exceeds present stock !!", "Quantity overloaded", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                int total = Convert.ToInt32(billMedQty.Text) * unitP;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(medDetails);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = billMedSelect.SelectedValue.ToString();
                newRow.Cells[2].Value = billMedQty.Text;
                newRow.Cells[3].Value = unitP;
                newRow.Cells[4].Value = unitP * Convert.ToInt32(billMedQty.Text);
                medDetails.Rows.Add(newRow);
                grandTotal = grandTotal + total;
                totalAmount.Text = "Your total bill is " + grandTotal.ToString();
                n = n + 1;
                medUpdate();
            }
        }
    }
}
