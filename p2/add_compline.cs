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
using System.IO;

namespace p2
{
    public partial class add_compline : Form
    {
        public add_compline()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void add_compline_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            int id;
            dateTimePicker1.Value = DateTime.Now;

            Program.Command.CommandText = string.Format("select top 1 Compline_id from Compline order by Compline_id desc");
            SqlDataReader data = Program.Command.ExecuteReader();
            
                data.Read();
            if (data.HasRows)
            {
                id = int.Parse(data[0].ToString());
                id = id + 1;
                label14.Text = id.ToString();
            }
            else
            {
                id = 1;
                label14.Text = id.ToString();
            }
                
            data.Close();
            Program.Connection.Close();


            //if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            //Program.Command.CommandText = string.Format("select distinct State_of_complaine from Compline ");
            //SqlDataReader data1 = Program.Command.ExecuteReader();
            //while (data1.Read())
            //    comboBox1.Items.Add(data1[0].ToString());
            //data1.Close();
            //Program.Connection.Close();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text==""|| textBox10.Text == "" || textBox11.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox5.Text == "" || comboBox1.SelectedItem == null || textBox7.Text==null)
            {
                MessageBox.Show("error");
            }

            else
            {
               


                if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                
                dateTimePicker1.Value = DateTime.Now;
                //string trider = textBox5.Text;
                //byte[] bytes = Encoding.Default.GetBytes(trider);
                //trider = Encoding.UTF8.GetString(bytes); // send the data to the sql server

                Program.Command.CommandText = string.Format("insert into Compline(bill_number,Trader_name,trader_phone,customer_name,customer_phone_number,date_enter_compline,explain_complain,notic,State_of_complaine,complain_type,reciver) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}') ", textBox1.Text,textBox5.Text, textBox4.Text, textBox11.Text, textBox10.Text, dateTimePicker1.Value, richTextBox1.Text, textBox7.Text, comboBox1.SelectedItem.ToString(), textBox3.Text, textBox6.Text);

                Program.Command.ExecuteNonQuery();
                MessageBox.Show("add complain succes");

                Program.Connection.Close();
                textBox1.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedItem = null;
                textBox7.Clear();
                richTextBox1.Clear();
            }

            //    foreach(Control c in this.Controls)
            //{
            //    if(c is TextBox )
            //    {
            //    (c as TextBox).Clear();
            //    }
            //}

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox10.Clear();
             textBox11.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedItem=null;
            textBox7.Clear(); ;
            richTextBox1.Clear();
                
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void compID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
