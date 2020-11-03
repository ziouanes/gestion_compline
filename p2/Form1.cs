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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkHide_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();
                //{

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("champ vide");
                    }


                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("champ vide");
                    }


                }
                else
                    {
                        if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

                        Program.Command.CommandText = string.Format("select Role_1,userid,password_1 from admin_1 where userid='{0}' and password_1='{1}'", textBox1.Text, textBox2.Text);
                        SqlDataReader r = Program.Command.ExecuteReader();
                        if (r.HasRows)
                        {
                            r.Read();
                            Program.role = r[0].ToString();
                        MessageBox.Show("welcome " + r[1]);
                            r.Close();
                            Program.Connection.Close();
                            this.Close();
                        }
                        else
                        {

                            Program.Connection.Close();
                            Program.role = "";
                            MessageBox.Show("Incorect user or pass");
                        }




                    }
                
            }

            catch (Exception x)
            {
                Program.Connection.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            textBox1.Focus();
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
              //  button1.KeyPress();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }
    }
}
