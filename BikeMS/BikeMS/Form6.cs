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
    public partial class Form6 : Form
    {

        string[] prds = new string[50];
        int[] qty = new int[50];
        int[] pprice = new int[50];
        int counter = 0;

        Form2 conn = new Form2();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            button17.Text = "Create";
            label21.Text = "POID";
            label20.Text = "GRNID";
            label19.Text = "VID";
            label18.Text = "V Name";
            label17.Text = "Total Amount ";
            label16.Text = "Po Due Date";
            label22.Text = "items Recieving Date";
            label15.Text = "Status";
          

            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select poid from po", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@poid", this.comboBox4.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox4.Items.Add(dr["poid"].ToString());
            }
            conn.sqlConnection1.Close();















            panel3.Visible = false;
            this.button6.Text = "ADD Value";
            this.button9.Text = "Insert Data";
            this.button1.Text = "New PO";
            this.button8.Text = "Close";
            this.button7.Text = "Home";
            this.button10.Text = "Create Purchase Order";
            this.button11.Text = "Create GRN";
            this.button12.Text = "Invoice Receiveable";
            this.button13.Text = "Close";
            this.button14.Text = "Home";



            conn.sqlConnection1.Open();
            SqlCommand cmr = new SqlCommand("Select Pro_Model from Products", conn.sqlConnection1);
            SqlDataReader drr = cmr.ExecuteReader();
            while (drr.Read())
            {
                comboBox3.Items.Add(drr["Pro_Model"].ToString());

            }
            conn.sqlConnection1.Close();



            conn.sqlConnection1.Open();
            SqlCommand cme = new SqlCommand("Select Ven_id from vender", conn.sqlConnection1);
            SqlDataReader dre = cme.ExecuteReader();
            while (dre.Read())
            {
                comboBox2.Items.Add(dre["Ven_id"].ToString());

            }
            conn.sqlConnection1.Close();






            conn.sqlConnection1.Open();
            SqlCommand cm3 = new SqlCommand("Select vname from po", conn.sqlConnection1);
            SqlDataReader dr3 = cm3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3["vname"].ToString());

            }
            conn.sqlConnection1.Close();



            groupBox2.Text = "Product Info";
            groupBox1.Text = "Vender Info";
            groupBox3.Text = "Purchase Order Info";
            this.label1.Text = "V ID";
            this.label2.Text = "V Name";
            this.label3.Text = "Contact Person";
            this.label4.Text = "PH # ";
            this.label5.Text = "Depart";
            this.label6.Text = "POID";
            this.label7.Text = "PO Date";
            this.label8.Text = "P Model";
            this.label9.Text = "P Name";
            this.label10.Text = "P Price";
            this.label11.Text = "Quantity";
            this.label12.Text = "Total price";
            this.label13.Text = "PO Due Date";
            this.button2.Text = "ADD Value";
            this.button3.Text = "Insert Data";
            this.button4.Text = "Close";
            this.button2.Text = "New PO";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(poid) from po", conn.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = Convert.ToInt32(dr[0]); c++;
            }
            {
                textBox4.Text = "" + c.ToString() + "";
            }
            conn.sqlConnection1.Close();



            //int c = 0;
            //conn.sqlConnection1.Open();
            //SqlCommand cmd = new SqlCommand("select count(poid) from po where vname  = '" + comboBox1.Text + "'", conn.sqlConnection1);

            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    c = Convert.ToInt32(dr[0]); c++;
            //}
            //if (comboBox1.Text == "Honda")
            //{
            //    textBox4.Text = "Hon-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            //}
            //if (comboBox1.Text == "Yamaha")
            //{
            //    textBox4.Text = "Ya-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            //}
            //if (comboBox1.Text == "Civic")
            //{
            //    textBox4.Text = "CV-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            //}
            //if (comboBox1.Text == "Mehran")
            //{
            //    textBox4.Text = "Meh-00" + c.ToString() + "-" + System.DateTime.Today.Year;
            //}

            //conn.sqlConnection1.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Select * from Vender where Ven_id=@Ven_id", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Ven_id", this.comboBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Ven_Comp_Name"].ToString();
                textBox2.Text = dr["Con_PerName"].ToString();
                textBox3.Text = dr["CP_Ph#"].ToString();

                conn.sqlConnection1.Close();

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Select * from Products where Pro_Model=@Pro_Model", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@Pro_Model", this.comboBox3.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox5.Text = dr["Pro_Company"].ToString();
                textBox6.Text = dr["Pro_MarketPrice"].ToString();
                //textBox3.Text = dr[""].ToString();

                conn.sqlConnection1.Close();

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int baseprice = 0;
            int productqty = 0;
            baseprice = Convert.ToInt32(textBox6.Text);
            productqty = Convert.ToInt32(textBox7.Text);
            this.textBox8.Text = Convert.ToString(baseprice * productqty);
            prds[counter] = comboBox3.Text;
            qty[counter] = Convert.ToInt32(textBox7.Text);
            pprice[counter] = Convert.ToInt32(textBox8.Text);
            counter++;



            this.textBox9.Text += "PURCHASE ORDER" + Environment.NewLine;
            this.textBox9.Text += "Vender Name:" + comboBox1.Text + Environment.NewLine;
            this.textBox9.Text += "PO_ID:" + textBox4.Text + Environment.NewLine;
            this.textBox9.Text += "PO Issue date:" + dateTimePicker1 + Environment.NewLine;
            this.textBox9.Text += "PO delivery date:" + dateTimePicker2 + Environment.NewLine;

            this.textBox9.Text += "****Vendor detail****" + Environment.NewLine;
            this.textBox9.Text += "vendor id:" + comboBox2.Text + Environment.NewLine;
            this.textBox9.Text += "Vendorname:" + textBox1.Text + Environment.NewLine;
            this.textBox9.Text += "Contact person:" + textBox2.Text + Environment.NewLine;
            this.textBox9.Text += "CP ph#:" + textBox3.Text + Environment.NewLine;

            this.textBox9.Text += "***Product deatai" + Environment.NewLine;
            this.textBox9.Text += "Product id:" + comboBox3.Text + Environment.NewLine;
            this.textBox9.Text += "Product name:" + textBox5.Text + Environment.NewLine;
            this.textBox9.Text += "Product price:" + textBox6.Text + Environment.NewLine;
            this.textBox9.Text += "Product quantity:" + textBox7.Text + Environment.NewLine;
            this.textBox9.Text += "Total Price:" + textBox8.Text + Environment.NewLine;

            MessageBox.Show("Value edited......");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (int p in pprice)
            {
                c += p + c;
            }
            conn.sqlConnection1.Open();

            SqlCommand cmd = new SqlCommand("Insert into po(poid,vid,vname,cpname,cpph)values(@poid,@vid,@vname,@cpname,@cpph)", conn.sqlConnection1);
            // cmd.Parameters.AddWithValue("@vname", comboBox2.Text);
            cmd.Parameters.AddWithValue("@poid", textBox4.Text);
            cmd.Parameters.AddWithValue("@vid", comboBox2.Text);
            cmd.Parameters.AddWithValue("@vname", textBox1.Text);
            cmd.Parameters.AddWithValue("@cpname", textBox2.Text);
            cmd.Parameters.AddWithValue("@cpph", textBox3.Text);
            //cmd.Parameters.AddWithValue("@PPrice",s);


            for (int i = 0; i < counter; i++)
            {

                SqlCommand cmdd = new SqlCommand("Insert into poproduct(pmodel,poid,pqty)values(@pmodel,@poid,@pqty)", conn.sqlConnection1);

                cmdd.Parameters.AddWithValue("@pmodel", comboBox3.Text);
                cmdd.Parameters.AddWithValue("@poid", textBox4.Text);
                cmdd.Parameters.AddWithValue("@pqty", qty[i]);
                cmdd.ExecuteNonQuery();
            }
            MessageBox.Show("Data Has been Inserted");

            conn.sqlConnection1.Close();


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Text = "";
            groupBox2.Text = "";
            groupBox3.Text = "";
            textBox9.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            conn.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Insert into grn(poid,grnid,vname,poddate,grndate)values(@poid,@grnid,@vname,@poddate,@grndate)", conn.sqlConnection1);
            cmd.Parameters.AddWithValue("@poid", comboBox4.Text);
            cmd.Parameters.AddWithValue("@grnid", textBox14.Text);
            cmd.Parameters.AddWithValue("@vname", textBox12.Text);
            // cmd.Parameters.AddWithValue("@", textBox3.Text);
            cmd.Parameters.AddWithValue("@poddate", dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@grnrdate", dateTimePicker3);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has been Inserted");
            conn.sqlConnection1.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {



            conn.sqlConnection1.Open();
            SqlCommand cmd1 = new SqlCommand("Select vid,vname,cpname,ddate,totalamount,postatus From po where poid=@poid ", conn.sqlConnection1);
            cmd1.Parameters.AddWithValue("@poid", this.comboBox4.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                textBox13.Text = dr1["vid"].ToString();
                textBox12.Text = dr1["vname"].ToString();
                //textBox12.Text = dr1["cpname"].ToString();
                //dateTimePicker4 = dr1["ddate"].ToString();
                textBox11.Text = dr1["totalamount"].ToString();
                textBox10.Text = dr1["postatus"].ToString();

                conn.sqlConnection1.Close();


                int c = 0;
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select count(grnid) from grn where poid='" + comboBox4.Text + "'", conn.sqlConnection1);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]); c++;
                }
                {
                    textBox14.Text = "GRN-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                conn.sqlConnection1.Close();





                conn.sqlConnection1.Open();

                SqlCommand cmdd = new SqlCommand("Select * from poproduct where poid=@poid", conn.sqlConnection1);
                cmdd.Parameters.AddWithValue("@poid", this.dataGridView1.Text);
                SqlDataReader drr = cmdd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(drr);
                dataGridView1.DataSource = dt;
                conn.sqlConnection1.Close();

            }
        }
    }
}
