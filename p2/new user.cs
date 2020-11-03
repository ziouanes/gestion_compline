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
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void new_user_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            //if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            //Program.Command.CommandText = string.Format("SELECT distinct Role_1 FROM admin_1");
            //SqlDataReader data = Program.Command.ExecuteReader();
            //while (data.Read())
            //    comboBox1.Items.Add(data[0].ToString());
            //data.Close();
            //Program.Connection.Close();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("mandatory field !!");
            }
            else
            {
                if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                //Program.Command.CommandText = string.Format("select top 1 Compline_id from Compline order by Compline_id desc");
                Program.Command.CommandText = string.Format("insert into admin_1(userid,Role_1,password_1) values (N'{0}','{1}',N'{2}') ", textBox2.Text, comboBox1.SelectedItem, textBox3.Text);
                Program.Command.ExecuteNonQuery();
                MessageBox.Show("admin  " + textBox2.Text.ToUpper() + " successfully added ", " Well added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Connection.Close();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
