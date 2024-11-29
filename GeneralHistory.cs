using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ITS245_FinalProject
{
    public partial class GeneralHistory : Form
    {
        int pid;
        MySqlConnection conn;
        public GeneralHistory()
        {
            InitializeComponent();
        }

        public GeneralHistory(MySqlConnection conn, int pid)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GeneralHistory_Load(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                
                string query = "SELECT PatientID, GeneralMedicalHistoryID FROM generalmedicalhistory";
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["PatientID"].ToString());
                            comboBox2.Items.Add(reader["GeneralMedicalHistoryID"].ToString());
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.MakeConnection();
            pid = Convert.ToInt16(comboBox1.Text);
                using (conn)
                {
                    string query = "SELECT * FROM generalmedicalhistory WHERE PatientID = @pid";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMaritalStat.Text = reader["MaritalStatus"].ToString(); 
                                txtEducation.Text = reader["Education"].ToString();
                                txtBehavioral.Text = reader["BehavioralHistory"].ToString();
                                txt_Tobacco.Text = reader["Tobacco"].ToString();
                                txt_TobaccoDur.Text = reader["TobaccoDuraton"].ToString();
                                txt_TobaccoQuant.Text = reader["TobaccoQuantity"].ToString();
                                txtAlc.Text = reader["Alcohol"].ToString();
                                txtAlcDur.Text = reader["AlcoholDuration"].ToString();
                                txtDrug.Text = reader["Drug"].ToString();
                                txtDrugType.Text = reader["DrugType"].ToString();
                                txtDrugDur.Text = reader["DrugDuration"].ToString();
                                txtDiet.Text = reader["Dietary"].ToString();
                                txtBloodType.Text = reader["BloodType"].ToString();
                                txtRH.Text = reader["Rh"].ToString();
                                txtChildrenNum.Text = reader["NumberOfChildren"].ToString();
                                txtLMPStat.Text = reader["LMPStatus"].ToString();
                                txtMensesMonth.Text = reader["MensesMonthlyYes"].ToString();
                                txtMensesNo.Text = reader["MensesMonthlyNo"].ToString();
                                txtMenseFreq.Text = reader["MensesFreq"].ToString();
                                txtHx.Text = reader["HxObtainedBy"].ToString();
                                txtHistNotes.Text = reader["MedicalHistoryNotes"].ToString(); 
                             }
                            else
                            {
                                MessageBox.Show("No data found for the selected PatientID.");
                            }
                        }
                    }
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pid = Convert.ToInt16(comboBox1.Text);
        }
    }
}
