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
    public partial class Form5 : Form
    {
        Form2 conn = new Form2();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Cutomer Id";
            this.label2.Text = "Cus Name";
            this.label3.Text = "Cus-Ph1#";
            this.label4.Text = "Cus-Ph2#";
            this.label5.Text = "Cus-Email";
            this.label6.Text = "Cus-City";
            this.label7.Text = "Cus-Address";
            this.label8.Text = "Cus-Depart";
           // this.label9.Text = "Ven-Code";
            this.label9.Text = "Contact Person";
            this.label10.Text = "CP-Ph#";
            this.label11.Text = "CP-Email";
            this.label12.Text = "Cus Account#";
            this.label13.Text = "Cus Status";



            this.label16.Text = "Cutomer Id";
            this.label17.Text = "Cus Name";
            this.label18.Text = "Cus-Ph1#";
            this.label19.Text = "Cus-Ph2#";
            this.label20.Text = "Cus-Email";
            this.label21.Text = "Cus-City";
            this.label22.Text = "Cus-Address";
            this.label23.Text = "Cus-Depart";
            // this.label9.Text = "Ven-Code";
            this.label25.Text = "Contact Person";
            this.label26.Text = "CP-Ph#";
            this.label27.Text = "CP-Email";
            this.label28.Text = "Cus Account#";
            this.label29.Text = "Cus Status";



            label30.Text = "Menu";
            this.button10.Text = "Search";
            this.button9.Text = "Update";
             this.button6.Text = "Delete";
            this.button4.Text = "Insert";
           // this.button3.Text = "Show";
            this.button11.Text = "Close";
            this.button12.Text = "Home Page";
            this.button5.Text = "Add Customer";
            this.button7.Text = "Update";
            this.button8.Text = "Delete";
            button1.Text = "Close";
            button2.Text = "Close";


            conn.sqlConnection1.Open();
            SqlCommand cmdd = new SqlCommand("Select c_status from C_Status", conn.sqlConnection1);
            SqlDataReader drr = cmdd.ExecuteReader();
            while (drr.Read())
            {
                comboBox4.Items.Add(drr["c_status"].ToString());

            }
            conn.sqlConnection1.Close();

            conn.sqlConnection1.Open();
            SqlCommand cmd1 = new SqlCommand("Select c_status from C_Status", conn.sqlConnection1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox5.Items.Add(dr1["c_status"].ToString());

            }
            conn.sqlConnection1.Close();



            conn.sqlConnection1.Open();
            SqlCommand cm3= new SqlCommand("Select Dept_Name from Department", conn.sqlConnection1);
            SqlDataReader dr3 = cm3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3["Dept_Name"].ToString());

            }
            conn.sqlConnection1.Close();




            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select Dept_Name from Department", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["Dept_Name"].ToString());

            }
            conn.sqlConnection1.Close();


            panel2.Visible = false;
            panel3.Visible = false;
            //button7.Visible = false;

            //button8.Visible = false;

            //button8.Visible = false;
            conn.sqlConnection1.Open();

            SqlCommand cmd2 = new SqlCommand("Select Cus_id from Customer", conn.sqlConnection1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["Cus_id"].ToString());

            }
            conn.sqlConnection1.Close();






        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Select * from Customer where Cus_id=@Cus_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_id", this.comboBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox15.Text = dr["Cus_Name"].ToString();
                textBox16.Text = dr["Cus_Ph1#"].ToString();
                textBox17.Text = dr["Cus_Ph2#"].ToString();
                textBox18.Text = dr["Cus_email"].ToString();
                textBox19.Text = dr["Cus_City"].ToString();
                textBox20.Text = dr["Cus_Address"].ToString();
                comboBox3.Text = dr["Cus_Dept"].ToString();
                //textBox22.Text = dr["Ven_Code"].ToString();
                textBox23.Text = dr["Con_PerName"].ToString();
                textBox24.Text = dr["CP_Ph#"].ToString();
                textBox25.Text = dr["CP_email"].ToString();
                textBox26.Text = dr["Cus_Account#"].ToString();
                comboBox4.Text = dr["Cus_Status"].ToString();

                conn.sqlConnection1.Close();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int c = 0;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select count(Cus_id) from Customer", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }
            {
                textBox1.Text = "" + c.ToString() + "";
            }
            conn.sqlConnection1.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Update Customer set Cus_Name=@Cus_Name ,Cus_Ph1#=@Cus_Ph1# ,Cus_Ph2#=@Cus_Ph2# ,Cus_email=@Cus_email ,Cus_City=@Cus_City,Cus_Address=@Cus_Address,Cus_Dept=@Cus_Dept,Con_PerName=@Con_PerName,CP_Ph#=@CP_Ph#,CP_email=@CP_email,Cus_Account#=@Cus_Account#,Cus_Status=@Cus_Status where  Cus_id=@Cus_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_id", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Cus_Name", textBox15.Text);
            cmd.Parameters.AddWithValue("@Cus_Ph1#", textBox16.Text);
            cmd.Parameters.AddWithValue("@Cus_Ph2#", textBox17.Text);
            cmd.Parameters.AddWithValue("@Cus_email", textBox18.Text);
            cmd.Parameters.AddWithValue("@Cus_City", textBox19.Text);
            cmd.Parameters.AddWithValue("@Cus_Address", textBox20.Text);
            cmd.Parameters.AddWithValue("@Cus_Dept", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Con_PerName", textBox23.Text);
            cmd.Parameters.AddWithValue("@CP_Ph#", textBox24.Text);
            cmd.Parameters.AddWithValue("@CP_email", textBox25.Text);
            cmd.Parameters.AddWithValue("@Cus_Account#", textBox26.Text);
            cmd.Parameters.AddWithValue("@Cus_Status", comboBox4.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            conn.sqlConnection1.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Delete  from Customer where Cus_id=@Cus_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_id", this.comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            conn.sqlConnection1.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Insert into Customer(Cus_id,Cus_Name ,Cus_Ph1#,Cus_Ph2# ,Cus_email,Cus_City,Cus_Address,Cus_Dept,Con_PerName,CP_Ph#,CP_email,Cus_Account#,Cus_Status)values(@Cus_id,@Cus_Name ,@Cus_Ph1# ,@Cus_Ph2# ,@Cus_email ,@Cus_City,@Cus_Address,@Cus_Dept,@Con_PerName,@CP_Ph#,@CP_email,@Cus_Account#,@Cus_Status)", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Cus_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Cus_Ph1#", textBox3.Text);
            cmd.Parameters.AddWithValue("@Cus_Ph2#", textBox4.Text);
            cmd.Parameters.AddWithValue("@Cus_email", textBox5.Text);
            cmd.Parameters.AddWithValue("@Cus_City", textBox6.Text);
            cmd.Parameters.AddWithValue("@Cus_Address", textBox7.Text);
            cmd.Parameters.AddWithValue("@Cus_Dept", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Con_PerName", textBox8.Text);
            cmd.Parameters.AddWithValue("@CP_Ph#", textBox9.Text);
            cmd.Parameters.AddWithValue("@CP_email", textBox10.Text);
            cmd.Parameters.AddWithValue("@Cus_Account#", textBox11.Text);
            cmd.Parameters.AddWithValue("@Cus_Status", comboBox5.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has been Inserted");
            conn.sqlConnection1.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}