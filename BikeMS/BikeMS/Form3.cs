using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;
namespace BikeMS
{
    public partial class Form3 : Form
    {
        Form2 conn = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.button11.Visible = false;
            this.dataGridView1.Visible = false;
                this.Text = "SHOWROOM MAANGEMENT SYSTEM";
            this.label1.Text = "MENU";
            this.label2.Text = "Check The Complete Data";
            this.button1.Text = "Vender";
            this.button2.Text = "Customer";
            //this.button3.Text = "Product";
            //this.button4.Text ="Department";
            this.button5.Text = "Staff";
            this.button6.Text = "Vender";
            this.button7.Text = "Customer";
            this.button8.Text = "Product";
            this.button9.Text = "Department";
            this.button10.Text = "Staff";
            this.button4.Text = "Sales cycle";
            this.button3.Text = "Purchase Cycle";
            this.button5.Text = "Employee";
        }
 
        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.button11.Visible = true;
            conn.sqlConnection1.Open();
             SqlCommand cmd = new SqlCommand("Select * from Vender", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.sqlConnection1.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button11.Visible = false;
            this.dataGridView1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.button11.Visible = true;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customer", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.sqlConnection1.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.button11.Visible = true;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Products", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.sqlConnection1.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.button11.Visible = true;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Department", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.sqlConnection1.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.button11.Visible = true;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
          

        }
    }
}
