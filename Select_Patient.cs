using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ITS245_FinalProject
{
    public partial class Select_Patient : Form
    {
        MySqlConnection conn;
        DataTable dt;
        public Select_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Select_Patient_Load(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    dt = DBUtils.GetPatients(conn);
                    PatientView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed in GetAllPatients" + ex.Message);
                }


            }
        }

        private void PatientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String s = "";
            s = PatientView.CurrentRow.ToString();
            MessageBox.Show("DB Connection Error: " +s);

            s = s.Substring(0, s.IndexOf(" "));
            MessageBox.Show("DB Connection Error: " + s);

            string connString = "server=127.0.0.1;uid=root;pwd=FUCKTHEFRENCH;database=crm";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(connString, conn);
                    //MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();

                    cmd.CommandText = "SELECT PhoneNumber " + "FROM customers WHERE FirstName = '" + s + "'";
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        textBox3.Text = reader[0].ToString();
                    }
                    reader.Close();
                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Connection Error: " + ex.Message);
                }

            }
        }
    }
}
