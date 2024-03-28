using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JCUBE_SE_PROJECT
{
    public class LogDao
    {
        private readonly SqlConnection cn;

        public LogDao(SqlConnection CN)
        {
            cn = CN;
        }

        public void AddLogs(string action, string type, string description, string username)
        {
            try
            {
                Console.WriteLine("hi");
                SqlCommand cm = new SqlCommand("INSERT INTO tbLogs (Action, Type, Description, Username, Date) VALUES (@LogAction, @LogType, @LogDescription, @LogUsername, GETDATE())", cn);
                cm.Parameters.AddWithValue("@LogAction", action);
                cm.Parameters.AddWithValue("@LogType", type);
                cm.Parameters.AddWithValue("@LogDescription", description);
                cm.Parameters.AddWithValue("@LogUsername", username);
                cm.ExecuteNonQuery();
                Console.WriteLine("hello");
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions here (e.g., logging the error)
                throw ex;
            }
        }
    }


}
