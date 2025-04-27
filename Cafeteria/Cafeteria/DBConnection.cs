using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    internal class DBConnection
    {
        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.conn);
        public void Execute(string command)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Command executed successfully.");
                }
                else
                {
                    Console.WriteLine("Command execution failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public DataTable Load(string command)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, sqlCon);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public int ExecuteScalar(string command)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
