using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HandleDB
    {
        public SqlConnection connection = new SqlConnection();
        public HandleDB()
        {
            try
            {
                connection.ConnectionString = @"Data Source=TrieuVy\TRIEUVY;Initial Catalog=QLST;Integrated Security=True";
                connection.Open();
            }catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro connection "+ex);
            }
        }
    }
}
