using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCUBE_SE_PROJECT
{
    public class AccountDeletion
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public void AccountAge(SqlConnection cn)
        {
            cn.Open();
            using (SqlCommand command = new SqlCommand("UPDATE tbUserArchive SET accountAge = DATEDIFF(day, TimeArchived, GETDATE()) FROM tbUserArchive WHERE TimeArchived IS NOT NULL", cn))
            {
                command.ExecuteNonQuery();
            }
            cn.Close();
        }

        public void ExpiredAccounts(SqlConnection cn)
        {
            cn.Open();
            using (SqlCommand command = new SqlCommand("DELETE FROM tbUserArchive WHERE accountAge >= 30", cn))
            {
                command.ExecuteNonQuery();
            }
            cn.Close();
        }
    }
}
