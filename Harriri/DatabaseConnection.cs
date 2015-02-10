using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harriri
{

    class DatabaseConnection
    {
        private string sql_string;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter da_1;

        public string Sql
        {
            set { sql_string = value; }
        }

        public string connection_string
        {
            set { strCon = value; }
        }

        public DataTable GetConnection
        {
            get { return MyDataTable(); }
        }
        private DataTable MyDataTable() 
        {
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            da_1.Fill(dt);
            //da_1.Fill(dat_set, "Table_Data_1");
            con.Close();
            return dt;
        }
    }

}
