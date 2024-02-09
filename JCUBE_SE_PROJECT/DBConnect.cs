using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCUBE_SE_PROJECT
{
    class DBConnect
    {
        public string con;
        public string myConnection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\1_UST_3RD_YEAR_FILES\JCUBE SE PROJECT\JCUBE-SE-PROJECT\DBjcube.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
    }
}
