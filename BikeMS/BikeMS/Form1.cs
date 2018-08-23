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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.label1.Text = "Agha Khan Hospital Management System";
            //this.label1.Text = "UserName:";
            //this.label2.Text = "Password:";

           // this.label4.Text = "LOGIN";

            this.AcceptButton = button1;
            this.button1.Text = "LOGIN";

           // this.groupBox1.Text = "Enter Your Details";

            this.textBox1.CharacterCasing = CharacterCasing.Lower;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               /* SqlConnection conn = new SqlConnection(@"Data Source=MISHAL-E-EMAN\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login_tbl1 where username='" + textBox1.Text + "' and upassword='" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "11")
                {
                */
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                /*}

                else
                {
                    MessageBox.Show("Invalid UserName OR Password!");
                }
           */

        }
    }
}
