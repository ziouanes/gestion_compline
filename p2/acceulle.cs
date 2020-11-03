using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class acceulle : Form
    {
        public acceulle()
        {
            InitializeComponent();
        }

        private void conx_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.MdiParent = this;
            l.Show();
            
            if (Program.role == "1")
            {
                //gestion.Enabled = true;
                //foreach (ToolStripDropDownItem item in gestion.DropDownItems) { item.Visible = true; }
                
                show.Enabled = true;
                //g_cons.Enabled = true;
                ///

                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem3.Enabled = true;
                toolStripMenuItem4.Enabled = true;
                conx.Enabled = false;
                deconx.Enabled = true;


            }
            else if (Program.role == "2")
            {
               // gestion.Enabled = true;
               // foreach (ToolStripDropDownItem item in gestion.DropDownItems) { item.Visible = true; }
                show.Enabled = false;
               // g_cons.Enabled = false;

                ///


                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem3.Enabled = true;
                toolStripMenuItem4.Enabled = false;
                conx.Enabled = false;
                deconx.Enabled = true;


            }
            else
            {
                toolStripMenuItem1.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                toolStripMenuItem4.Enabled = false;
            }
        }
        
        
        private void show_Click(object sender, EventArgs e)
        {



            updateusers updateusers = new updateusers();
           // foreach (ToolStripDropDownItem item in gestion.DropDownItems) { item.Visible = true; }
            Program.cls(this);

            updateusers.ShowDialog();
        }
        //  066214295
        private void deconx_Click(object sender, EventArgs e)
        {
            Program.cls(this);
            //gestion.Enabled = false;
            //deconx.Enabled = false;
            //conx.Enabled = true;
            Program.cls(this);
            Program.role = "";

            ////////
            ///
            show.Enabled = false;

            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem4.Enabled = false;
            deconx.Enabled = false;
            conx.Enabled = true;


        }

        private void g_client_Click(object sender, EventArgs e)
        {
            Program.cls(this);
            add_compline add_compline = new add_compline();
            add_compline.ShowDialog();
        }

        private void g_prod_Click(object sender, EventArgs e)
        {
            edit edit = new edit();
            edit.ShowDialog();
        }

        private void g_commandes_Click(object sender, EventArgs e)
        {
            allcompline allcompline = new allcompline();
            allcompline.ShowDialog();
        }

        private void g_cons_Click(object sender, EventArgs e)
        {
            EDITALL eDITALL = new EDITALL();
            eDITALL.ShowDialog();
        }

        private void acceulle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
           // this.IsMdiContainer = true;
            Form1 f = new Form1();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void MS1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.cls(this);
            add_compline add_compline = new add_compline();
            add_compline.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            edit edit = new edit();
            edit.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            allcompline allcompline = new allcompline();
            allcompline.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            EDITALL eDITALL = new EDITALL();
            eDITALL.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void consulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void g_cons_Click(object sender, EventArgs e)
        ////{
        ////    Program.cls(this);
        ////    edit edit = new edit();
        ////    edit.ShowDialog();
        //}

        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}

        //private void g_commandes_Click(object sender, EventArgs e)
        //{
        //    Program.cls(this);
        //    allcompline allcompline = new allcompline();
        //    allcompline.ShowDialog();
        //}

        //private void acceulle_Load(object sender, EventArgs e)
        //{

        //}
    }
}
