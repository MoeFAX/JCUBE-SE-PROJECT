using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data;
using System.Data.SqlClient;
=======
using System.Data.SqlClient;
using System.Data;
>>>>>>> 9b803e62105503925e9b730ea80656ec53c3c8b8
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCUBE_SE_PROJECT
{
    class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
<<<<<<< HEAD
        private string con;
=======
        public string con;

>>>>>>> 9b803e62105503925e9b730ea80656ec53c3c8b8
        public string myConnection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herald\source\repos\JCUBE-SE-PROJECT\DBjcube.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
<<<<<<< HEAD

=======
>>>>>>> 9b803e62105503925e9b730ea80656ec53c3c8b8
        public DataTable getTable(string qury)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(qury, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
