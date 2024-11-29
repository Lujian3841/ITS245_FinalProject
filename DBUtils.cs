using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ITS245_FinalProject
{
    internal class DBUtils
    {
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=127.0.0.1; uid=root2; pwd=P@ssw0rd; " +
                "database=medinfo";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }
        public static DataTable GetPatients(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cmd = new MySqlCommand("GetAllPatientsSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve All Patients Error: Error = " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
            }
            return dt;
        }
        public static DataTable GetPatientByIDSP(MySqlConnection conn, int pid)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cmd = new MySqlCommand("GetPatientByIDSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve Patient by ID Error: " +
                    ex.Message);
            }
            finally
            {
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable GetPatientByIDGenHistSP(MySqlConnection conn, int pid)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cmd = new MySqlCommand("GetPatientByIDGenHistSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve Patient GenHist: " + ex.Message);
            }
            finally
            {

                cmd.Dispose();
            }


            return dt;
        }
    }
}
