using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatBom_DA1
{
    public class DbContext
    {
        private static DbContext instance;
        private DbContext() { }

        private string ConStr = "Data Source=DESKTOP-6ODFHLP\\VUONGSQL;Initial Catalog=GameDoAn1;Integrated Security=True";
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataAdapter data = null;

        public static DbContext Instance 
        {
            get { if (instance == null) instance = new DbContext(); return DbContext.instance; }
            private set { DbContext.instance = value; }
        }

        //
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable datatable = new DataTable();
            using (connection = new SqlConnection(ConStr))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] Listparameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in Listparameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                data = new SqlDataAdapter(command);
                data.Fill(datatable);
                connection.Close();
            }
            return datatable;
        }
    }
}
