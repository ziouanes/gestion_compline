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

namespace p2
{
    public partial class EDITALL : Form
    {
        public EDITALL()
        {
            InitializeComponent();
        }

        private void EDITALL_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            if (Program.role == "1")
            {
                button3.Enabled = true;

            }
            else
            {

                button3.Enabled = false;


            }
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("select  Compline_id from Compline ");
            SqlDataReader data = Program.Command.ExecuteReader();
            while (data.Read())
                comboBox2.Items.Add(data[0].ToString());
            data.Close();
            Program.Connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("select bill_number,Trader_name,trader_phone,customer_name,customer_phone_number,date_enter_compline,explain_complain,notic,State_of_complaine,complain_type,reciver,solved_by FROM Compline  where Compline_id  = '{0}' ", comboBox2.SelectedItem.ToString());
            SqlDataReader data = Program.Command.ExecuteReader();

            data.Read();
            textBox1.Text = data[0].ToString();
            textBox5.Text = data[1].ToString();
            textBox4.Text = data[2].ToString();
            textBox11.Text = data[3].ToString();
            textBox10.Text = data[4].ToString();
            dateTimePicker1.Value = DateTime.Parse(data[5].ToString());
            richTextBox1.Text = data[6].ToString();
            textBox7.Text = data[7].ToString();




            comboBox1.SelectedItem = data[8].ToString();
            textBox3.Text = data[9].ToString();
            textBox6.Text = data[10].ToString();
            textBox2.Text = data[11].ToString();



            data.Close();
            Program.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || richTextBox1.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox5.Text == "" || comboBox1.SelectedItem == null || textBox7.Text == null)
            {
                MessageBox.Show("error");
            }
            else
            {
                if (MessageBox.Show("Do you really want to change the code doctor? ", " Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                    Program.Command.CommandText = string.Format("update Compline set bill_number = N'{0}',Trader_name=N'{1}',trader_phone=N'{2}',customer_name=N'{3}',customer_phone_number=N'{4}',date_enter_compline='{5}',explain_complain=N'{6}',notic=N'{7}',State_of_complaine=N'{8}',complain_type=N'{9}',solved_by = N'{10}',reciver=N'{11}' where Compline_id = '{12}' ", textBox1.Text, textBox5.Text, textBox4.Text, textBox11.Text, textBox10.Text, dateTimePicker1.Value, richTextBox1.Text, textBox7.Text, comboBox1.SelectedItem.ToString(), textBox3.Text, textBox2.Text, textBox6.Text, comboBox2.SelectedItem.ToString());
                    Program.Command.ExecuteNonQuery();


                    MessageBox.Show("done.");

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




            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete the code doctor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                Program.Command.CommandText = string.Format("delete from Compline where Compline_id ='{0}' ", comboBox2.SelectedItem.ToString());
                Program.Command.ExecuteNonQuery();


                MessageBox.Show("done.");

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
            comboBox2.Items.Clear();

            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("select  Compline_id from Compline ");
            SqlDataReader data = Program.Command.ExecuteReader();
            while (data.Read())
                comboBox2.Items.Add(data[0].ToString());
            data.Close();
            Program.Connection.Close();
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
            comboBox1.SelectedItem = null;
            textBox7.Clear();
            richTextBox1.Clear();
        }
    }
}
