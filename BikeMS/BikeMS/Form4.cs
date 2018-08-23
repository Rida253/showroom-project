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
    public partial class Form4 : Form
    {
        Form2 conn = new Form2();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            button7.Visible = false;

            button8.Visible = false;

            button8.Visible = false;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select Dept_Name from Department", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Dept_Name"].ToString());

            }
            conn.sqlConnection1.Close();

            

                conn.sqlConnection1.Open();
                SqlCommand cmde = new SqlCommand("Select Dept_Name from Department", conn.sqlConnection1);
                SqlDataReader dre = cmde.ExecuteReader();
                while (dre.Read())
                {
                    comboBox3.Items.Add(dre["Dept_Name"].ToString());

                }
                conn.sqlConnection1.Close();
            

            
                conn.sqlConnection1.Open();

            SqlCommand cmdd = new SqlCommand("Select Ven_id from Vender", conn.sqlConnection1);
            SqlDataReader drr = cmdd.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["Ven_id"].ToString());

            }
            conn.sqlConnection1.Close();


        


            this.label1.Text = "Vender Id";
            this.label2.Text = "Ven-Compnay Name";
            this.label3.Text = "Ven-Ph1#";
            this.label4.Text = "Ven-Ph2#";
            this.label5.Text = "Ven-Email";
            this.label6.Text = "Ven-City";
            this.label7.Text = "Ven-Address";
            this.label8.Text = "Ven-Depart";
            this.label9.Text = "Ven-Code";
            this.label10.Text = "Contact Person";
            this.label11.Text = "CP-Ph#";
            this.label12.Text = "CP-Email";
            this.label13.Text = "Vender Account#";
            this.label15.Text = "Vender Status";



            button5.Text = "Insert Data";

            button7.Text = "Update Data";


            button8.Text = "Delete Data";

            this.label16.Text = "Vender Id";
            this.label17.Text = "Ven-Compnay Name";
            this.label18.Text = "Ven-Ph1#";
            this.label19.Text = "Ven-Ph2#";
            this.label20.Text = "Ven-Email";
            this.label21.Text = "Ven-City";
            this.label22.Text = "Ven-Address";
            this.label23.Text = "Ven-Depart";
            this.label24.Text = "Ven-Code";
            this.label25.Text = "Contact Person";
            this.label26.Text = "CP-Ph#";
            this.label27.Text = "CP-Email";
            this.label28.Text = "Vender Account#";
            this.label29.Text = "Vender Status";
        }

        private void aDDNEWCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            button5.Visible = true;
            int c = 0;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select count(Ven_id) from Vender", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }
            {
                textBox1.Text = "" + c.ToString() + "-";
            }
            conn.sqlConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(Ven_id) from Vender where Ven_Dept='" + comboBox1.Text + "'", conn.sqlConnection1);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }

            if (comboBox1.Text == "Accounts")
            {
                textBox8.Text = "Acc-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "HR")
            {
                textBox8.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Sales")
            {
                textBox8.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }
            if (comboBox1.Text == "Marketing")
            {
                textBox8.Text = "Mar-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Management")
            {
                textBox8.Text = "Mana-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            if (comboBox1.Text == "Production")
            {
                textBox8.Text = "Prod-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            }

            conn.sqlConnection1.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
           	
            SqlCommand cmd = new SqlCommand("Insert into Vender(Ven_id,Ven_Comp_Name ,Vend_Ph1# ,Vend_Ph2# ,Ven_email ,Ven_City,Ven_Address,Ven_Dept,Ven_Code,Con_PerName,CP_Ph#,CP_email,Ven_Account#,Ven_Status)values( @Ven_id,@Ven_Comp_Name ,@Vend_Ph1# ,@Vend_Ph2# ,@Ven_email ,@Ven_City,@Ven_Address,@Ven_Dept,@Ven_Code,@Con_PerName,@CP_Ph#,@CP_email,@Ven_Account#,@Ven_Status)", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Ven_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Ven_Comp_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Vend_Ph1#", textBox13.Text);
            cmd.Parameters.AddWithValue("@Vend_Ph2#", textBox14.Text);
            cmd.Parameters.AddWithValue("@Ven_email", textBox15.Text);
            cmd.Parameters.AddWithValue("@Ven_City", textBox16.Text);
            cmd.Parameters.AddWithValue("@Ven_Address", textBox17.Text);
            cmd.Parameters.AddWithValue("@Ven_Dept", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Ven_Code", textBox18.Text);
            cmd.Parameters.AddWithValue("@Con_PerName", textBox19.Text);
            cmd.Parameters.AddWithValue("@CP_Ph#", textBox10.Text);
            cmd.Parameters.AddWithValue("@CP_email", textBox11.Text);
            cmd.Parameters.AddWithValue("@Ven_Account#", textBox12.Text);
            cmd.Parameters.AddWithValue("@Ven_Status", textBox13.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has been Inserted");
            conn.sqlConnection1.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Select * from Vender where Ven_id=@Ven_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Ven_id", this.comboBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox15.Text = dr["Ven_Comp_Name"].ToString();
                textBox16.Text = dr["Vend_Ph1#"].ToString();
                textBox17.Text = dr["Vend_Ph2#"].ToString();
                textBox18.Text = dr["Ven_email"].ToString();
                textBox19.Text = dr["Ven_City"].ToString();
                textBox20.Text = dr["Ven_Address"].ToString();
                comboBox3.Text = dr["Ven_Dept"].ToString();
                textBox22.Text = dr["Ven_Code"].ToString();
                textBox23.Text = dr["Con_PerName"].ToString();
                textBox24.Text = dr["CP_Ph#"].ToString();
                textBox25.Text = dr["CP_email"].ToString();
                textBox26.Text = dr["Ven_Account#"].ToString();
                textBox27.Text = dr["Ven_Status"].ToString();

                conn.sqlConnection1.Close();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Delete  from Vender where Ven_id=@Ven_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Ven_id", this.comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            conn.sqlConnection1.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Update Vender set Ven_Comp_Name=@Ven_Comp_Name ,Vend_Ph1#=@Vend_Ph1# ,Vend_Ph2#=@Vend_Ph2# ,Ven_email=@Ven_email ,Ven_City=@Ven_City,Ven_Address=@Ven_Address,Ven_Dept=@Ven_Dept,Ven_Code=@Ven_Code,Con_PerName=@Con_PerName,CP_Ph#=@CP_Ph#,CP_email=@CP_email,Ven_Status=@Ven_Status where  Ven_id=@Ven_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Ven_id", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Ven_Comp_Name", textBox15.Text);
            cmd.Parameters.AddWithValue("@Vend_Ph1#", textBox16.Text);
            cmd.Parameters.AddWithValue("@Vend_Ph2#", textBox17.Text);
            cmd.Parameters.AddWithValue("@Ven_email", textBox18.Text);
            cmd.Parameters.AddWithValue("@Ven_City", textBox19.Text);
            cmd.Parameters.AddWithValue("@Ven_Address", textBox20.Text);
            cmd.Parameters.AddWithValue("@Ven_Dept", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Ven_Code", textBox22.Text);
            cmd.Parameters.AddWithValue("@Con_PerName", textBox23.Text);
            cmd.Parameters.AddWithValue("@CP_Ph#", textBox24.Text);
            cmd.Parameters.AddWithValue("@CP_email", textBox25.Text);
            cmd.Parameters.AddWithValue("@Ven_Account#", textBox26.Text);
            cmd.Parameters.AddWithValue("@Ven_Status", textBox27.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            conn.sqlConnection1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int k = 0;
            //conn.sqlConnection1.Open();

            //SqlCommand cmd = new SqlCommand("select count(Ven_id) from Vender where Ven_Dept='" + comboBox3.Text + "'", conn.sqlConnection1);

            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    k = Convert.ToInt32(dr[0]); k++;
            //}

            //if (comboBox3.Text == "Accounts")
            //{
            //    textBox22.Text = "Acc-00" + k.ToString() + "-";
            //}
            //if (comboBox3.Text == "HR")
            //{
            //    textBox22.Text = "HR-00" + k.ToString() + "-" ;
            //}
            //if (comboBox3.Text == "Sales")
            //{
            //    textBox22.Text = "Sal-00" + k.ToString() + "-" ;
            //}
            //if (comboBox3.Text == "Marketing")
            //{
            //    textBox22.Text = "Mar-00" + k.ToString() + "-" ;
            //}

            //if (comboBox3.Text == "Management")
            //{
            //    textBox22.Text = "Mana-00" + k.ToString() + "-" ;
            //}

            //if (comboBox3.Text == "Production")
            //{
            //    textBox22.Text = "Prod-00" + k.ToString() + "-" ;
            //}

            //conn.sqlConnection1.Close();


        }

        private void sEARCHCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible=true;

        }

        private void uPDATECUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            this.button7.Visible = true;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            this.button8.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
    }

