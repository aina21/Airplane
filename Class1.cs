using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Airplane
{
   static class Class1
    {
       public static string connectionString = "Data Source=localhost;Initial Catalog=Airplane;Integrated Security=True";
        public static void SetData(string sqlStr)
        {
            SqlConnection mConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlStr, mConnection);
            command.CommandType = CommandType.Text;
            command.CommandText = sqlStr;
            mConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException myerror)
            {
                MessageBox.Show("Error Connecting to Database: " + myerror.Message);
               
            }
            finally
            {
                mConnection.Close();
                mConnection.Dispose();
            }
        }

        public static DataTable GetData(string sqlCommand)
        {
            SqlConnection mConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlCommand, mConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (SqlException myerror)
            {
                MessageBox.Show("Error Connecting to Database: " + myerror.Message);
            }
            finally
            {
                mConnection.Dispose();
            }
            return table;
        }

    }
}
