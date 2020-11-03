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
    public partial class allcompline : Form
    {
        public allcompline()
        {
            InitializeComponent();
        }

        private void allcompline_Load(object sender, EventArgs e)
        {

            timer1.Start();





            //try
            //{
            //    if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();


            //    SqlCommand gestionCmd = new SqlCommand("select c.Compline_id from bill b inner join Compline c on b.solved_by = c.Compline_id where b.State_of_complaine = 'sloved'", Program.Connection);
            //    SqlDataReader moduleReader = gestionCmd.ExecuteReader();
            //    if (moduleReader.HasRows)
            //    {
            //        moduleReader.Read();
            //        DataTable t = new DataTable();
            //        t.Load(moduleReader);
            //        comboBoxModule.DataSource = t;
            //        Program.Connection.Close();
            //        this.Close();
            //    }
            //    else
            //    {

            //        Program.Connection.Close();

            //    }






            //}
            //catch (Exception x)
            //{
            //    Program.Connection.Close();
            //    MessageBox.Show(x.Message);
            //}
        }

        private void groupBoxSelection_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            //try
            //{
            //    if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();
            //    string query = string.Format("select b.* from bill b inner join Compline c on b.solved_by = c.Compline_id where b.State_of_complaine = 'sloved' and c.Compline_id = '{0}'", comboBoxModule.SelectedItem.ToString());
            //    SqlCommand gestionCmd = new SqlCommand(query, Program.Connection);
            //    SqlDataReader infosReader = gestionCmd.ExecuteReader();
            //    DataTable tableInfos = new DataTable();
            //    tableInfos.Load(infosReader);
            //    dataGridViewModules.DataSource = null;
            //    dataGridViewModules.DataSource = tableInfos;
            //    infosReader.Close();
            //    Program.Connection.Close();



            //    // Modifier les en-têtes

            //}
            //catch (Exception x)
            //{
            //    Program.Connection.Close();
            //    MessageBox.Show(x.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.Connection.State == ConnectionState.Closed) Program.Connection.Open();

            Program.Command.CommandText = string.Format("select *  from Compline  ");

            SqlDataReader data = Program.Command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
            data.Close();


            Program.Connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
