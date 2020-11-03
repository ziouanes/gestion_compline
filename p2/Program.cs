using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    static class Program
    {




        // Attributs de SQL Server
          public static SqlConnection Connection = new SqlConnection(@"Data Source = AANDROID-123122\SQLEXPRESS; Initial Catalog = p1; Integrated Security = True");
        

       // public static SqlConnection Connection = new SqlConnection(@" server=192.168.0.10,1433; database=p2;  user id=admin;    password=123456");
        public static SqlCommand Command = new SqlCommand("", Connection);
        public static string role = "";
        public static void cls(Form frm)
        {
            foreach (Form f in frm.MdiChildren)
            {
                f.Close();
            }

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()      
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new acceulle());
            Application.Run(new acceulle());

        }

        //public static bool IsExist(string identifiant, string nomTable, string champ)
        //{
        //    if (champ != "NumCmd")
        //        identifiant = "'" + identifiant + "'";
        //    Connection.Open();
        //    Command = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + champ + "=" + identifiant + "", Connection);
        //    SqlDataReader data = Command.ExecuteReader();
        //    bool result = data.HasRows;
        //    data.Close();
        //    Connection.Close();
        //    return result;
        //}
    }
}
