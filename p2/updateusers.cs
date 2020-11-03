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
    public partial class updateusers : Form
    {
        public updateusers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_user new_User = new new_user();
            new_User.ShowDialog();
            this.Close();
        }

        private void updateusers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            comboBox1.Items.Clear();
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("SELECT  userid FROM admin_1");
            SqlDataReader data = Program.Command.ExecuteReader();
            while (data.Read())
                comboBox1.Items.Add(data[0].ToString());
            data.Close();
            Program.Connection.Close();
        }
        int id;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("SELECT id , password_1 FROM admin_1 where userid = '{0}' ",comboBox1.SelectedItem.ToString());
            SqlDataReader data = Program.Command.ExecuteReader();
            
                data.Read();
            textBox1.Text= data[1].ToString();
             id = int.Parse(data[0].ToString());


            data.Close();
            Program.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (  textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("mandatory field !!");
            }
            else
            {

                if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                Program.Command.CommandText = string.Format("update admin_1 set password_1 =  N'{0}' where id = N'{1}' ", textBox3.Text, id);
                Program.Command.ExecuteNonQuery();
                MessageBox.Show("update succes");
                Program.Connection.Close();

                comboBox1.Text = "";
                textBox1.Text = "";
                textBox3.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( comboBox1.Text == "")
            {
                MessageBox.Show("mandatory field !!");
            }
            else
            {
                if (MessageBox.Show("Do you really want to delete the code doctor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                    Program.Command.CommandText = string.Format("delete from admin_1 where userid ='{0}' ", comboBox1.SelectedItem.ToString());
                    Program.Command.ExecuteNonQuery();


                    MessageBox.Show("done.");

                    Program.Connection.Close();
                    comboBox1.Items.Clear();


                    if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                    Program.Command.CommandText = string.Format("SELECT  userid FROM admin_1");
                    SqlDataReader data = Program.Command.ExecuteReader();
                    while (data.Read())
                        comboBox1.Items.Add(data[0].ToString());
                    data.Close();
                    Program.Connection.Close();
                    comboBox1.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";


                }
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
