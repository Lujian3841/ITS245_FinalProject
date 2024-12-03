using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices.ComTypes;
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
        public static DataTable GetAllergys(MySqlConnection conn, int pid)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cmd = new MySqlCommand("getAllAllergens", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
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
        public static int InsertAllergenSP(MySqlConnection conn, Allergen a)
        {
            int returnedRecs = 0;


            try
            {
                MySqlCommand cmd = new MySqlCommand("InsertAllergySP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AllergyID", a.AllergenID);
                cmd.Parameters.AddWithValue("@pid", a.PID);
                cmd.Parameters.AddWithValue("@allergen", a.allergen);
                cmd.Parameters.AddWithValue("@StartDate", a.AllergenStart);
                cmd.Parameters.AddWithValue("@EndDate", a.AllergenEnd);
                cmd.Parameters.AddWithValue("@descrip", a.AllergenDescription);
                returnedRecs = cmd.ExecuteNonQuery();
                return returnedRecs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert of Allergen Failed!  Message=" + ex.Message);
            }
            return 0;
        }
        public static int UpdateAllergySP(MySqlConnection conn, Allergen a)
        {
            int returnedRecs = 0;


            try
            {
                MySqlCommand cmd = new MySqlCommand("UpdateAllergySP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@allergyID", a.AllergenID);
                cmd.Parameters.AddWithValue("@pid", a.PID);
                cmd.Parameters.AddWithValue("@allergen", a.allergen);
                cmd.Parameters.AddWithValue("@StartDate", a.AllergenStart);
                cmd.Parameters.AddWithValue("@EndDate", a.AllergenEnd);
                cmd.Parameters.AddWithValue("@descrip", a.AllergenDescription);
                cmd.Prepare();
                returnedRecs = cmd.ExecuteNonQuery();
                return returnedRecs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update of Allergen Failed!  Message=" + ex.Message);
            }
            return 0;
        }
        public static void fillDemo(MySqlConnection conn, int pid)
        {
            try
            {
             
            }
        }

    }
}
