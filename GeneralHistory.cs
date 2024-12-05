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
        int screenMode = 1;
        int pid;
        string patientinfo;

        MySqlConnection conn;
        public GeneralHistory()
        {
            InitializeComponent();
        }

        public GeneralHistory(int PID)
        {
            InitializeComponent();
            this.pid = PID;
        }

        public void patientLabel()
        {
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT PtFirstName, PtLastName, PtMiddleInitial FROM patientdemographics WHERE PatientID = @pid";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pid);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label1.Text = reader["PtFirstName"].ToString() + " " + reader["PtMiddleInitial"].ToString() + " " + reader["PtLastName"].ToString();
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GeneralHistory_Load(object sender, EventArgs e)
        {
            lockScreen();
            using (conn = DBUtils.MakeConnection())
            {
                string query = "SELECT GeneralMedicalHistoryID FROM generalmedicalhistory WHERE deleted = 0";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["GeneralMedicalHistoryID"].ToString());
                        }
                    }
                }
            }

            patientLabel();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.MakeConnection();
            pid = Convert.ToInt16(comboBox1.Text);
            using (conn)
            {
                string query = "SELECT * FROM generalmedicalhistory WHERE GeneralMedicalHistoryID = @pid and deleted = 0";

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
                            txtAlcQuant.Text = reader["AlcoholQuantity"].ToString();
                            txtDrug.Text = reader["Drug"].ToString();
                            txtDrugType.Text = reader["DrugType"].ToString();
                            txtDrugDur.Text = reader["DrugDuration"].ToString();
                            txtDiet.Text = reader["Dietary"].ToString();
                            txtBloodType.Text = reader["BloodType"].ToString();
                            txtRH.Text = reader["Rh"].ToString();
                            txtChildrenNum.Text = reader["NumberOfChildren"].ToString();
                            txtLMPStat.Text = reader["LMPStatus"].ToString();
                            int mensesYes = Convert.ToInt32(reader["MensesMonthlyYes"]);
                            int mensesNo = Convert.ToInt32(reader["MensesMonthlyNo"]);
                            txtMensesMonth.Text = mensesYes.ToString();
                            txtMensesNo.Text = mensesNo.ToString();
                            txtMenseFreq.Text = reader["MensesFreq"].ToString();
                            txtHx.Text = reader["HxObtainedBy"].ToString();
                            txtHistNotes.Text = reader["MedicalHistoryNotes"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the selected ID.");
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pid = Convert.ToInt16(comboBox1.Text);
        }

        private void formMode()
        {

        }

        public void lockScreen()
        {
            panel3.BackColor = Color.LightSlateGray;
            txtAlc.Enabled = false;
            txtAlcDur.Enabled = false;
            txtAlcQuant.Enabled = false;
            txtBehavioral.Enabled = false;
            txtBloodType.Enabled = false;
            txtChildrenNum.Enabled = false;
            txtDiet.Enabled = false;
            txtDrug.Enabled = false;
            txtDrugDur.Enabled = false;
            txtDrugType.Enabled = false;
            txtEducation.Enabled = false;
            txtHistNotes.Enabled = false;
            txtHx.Enabled = false;
            txtLMPStat.Enabled = false;
            txtMaritalStat.Enabled = false;
            txtMenseFreq.Enabled = false;
            txtMensesMonth.Enabled = false;
            txtMensesNo.Enabled = false;
            txtRH.Enabled = false;
            txt_Tobacco.Enabled = false;
            txt_TobaccoDur.Enabled = false;
            txt_TobaccoQuant.Enabled = false;

            screenMode = 1;
        }
        public void unlockScreen()
        {
            panel3.BackColor = Color.AliceBlue;
            txtAlc.Enabled = true;
            txtAlcDur.Enabled = true;
            txtAlcQuant.Enabled = true;
            txtBehavioral.Enabled = true;
            txtBloodType.Enabled = true;
            txtChildrenNum.Enabled = true;
            txtDiet.Enabled = true;
            txtDrug.Enabled = true;
            txtDrugDur.Enabled = true;
            txtDrugType.Enabled = true;
            txtEducation.Enabled = true;
            txtHistNotes.Enabled = true;
            txtHx.Enabled = true;
            txtLMPStat.Enabled = true;
            txtMaritalStat.Enabled = true;
            txtMenseFreq.Enabled = true;
            txtMensesMonth.Enabled = true;
            txtMensesNo.Enabled = true;
            txtRH.Enabled = true;
            txt_Tobacco.Enabled = true;
            txt_TobaccoDur.Enabled = true;
            txt_TobaccoQuant.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            unlockScreen();
            screenMode = 3;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            unlockScreen();
            screenMode = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.MakeConnection();

            using (conn)
            {
                try
                {
                    if (screenMode == 2)
                    {
                        string query = "UPDATE generalmedicalhistory " +
                                        "SET MaritalStatus = @marital, " +
                                        "Education = @education, " +
                                        "BehavioralHistory = @behavioral, " +
                                        "Tobacco = @tobacco, " +
                                        "TobaccoDuraton = @tobaccodur, " +
                                        "TobaccoQuantity = @tobaccoquan, " +
                                        "Alcohol = @alc, " +
                                        "AlcoholDuration = @alcdur, " +
                                        "AlcoholQuantity = @alcquan, " +
                                        "Drug = @drug, " +
                                        "DrugType = @drugtype, " +
                                        "DrugDuration = @drugdur, " +
                                        "Dietary = @diet, " +
                                        "BloodType = @bloodtype, " +
                                        "Rh = @rh, " +
                                        "NumberOfChildren = @childnum, " +
                                        "LMPStatus = @lmp, " +
                                        "MensesMonthlyYes = @mensesyes, " +
                                        "MensesMonthlyNo = @mensesno, " +
                                        "MensesFreq = @mensefreq, " +
                                        "HxObtainedBy = @hx, " +
                                        "MedicalHistoryNotes = @medhistnotes " +
                                        "WHERE GeneralMedicalHistoryID = @pid and deleted = '0'";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@marital", txtMaritalStat.Text);
                            cmd.Parameters.AddWithValue("@education", txtEducation.Text);
                            cmd.Parameters.AddWithValue("@behavioral", txtBehavioral.Text);
                            cmd.Parameters.AddWithValue("@tobacco", txt_Tobacco.Text);
                            cmd.Parameters.AddWithValue("@tobaccodur", txt_TobaccoDur.Text);
                            cmd.Parameters.AddWithValue("@tobaccoquan", txt_TobaccoQuant.Text);
                            cmd.Parameters.AddWithValue("@alc", txtAlc.Text);
                            cmd.Parameters.AddWithValue("@alcdur", txtAlcDur.Text);
                            cmd.Parameters.AddWithValue("@alcquan", txtAlcQuant.Text);
                            cmd.Parameters.AddWithValue("@drug", txtDrug.Text);
                            cmd.Parameters.AddWithValue("@drugtype", txtDrugType.Text);
                            cmd.Parameters.AddWithValue("@drugdur", txtDrugDur.Text);
                            cmd.Parameters.AddWithValue("@diet", txtDiet.Text);
                            cmd.Parameters.AddWithValue("@bloodtype", txtBloodType.Text);
                            cmd.Parameters.AddWithValue("@rh", txtRH.Text);
                            cmd.Parameters.AddWithValue("@childnum", txtChildrenNum.Text);
                            cmd.Parameters.AddWithValue("@lmp", txtLMPStat.Text);
                            cmd.Parameters.AddWithValue("@mensesyes", txtMensesMonth.Text);
                            cmd.Parameters.AddWithValue("@mensesno", txtMensesNo.Text);
                            cmd.Parameters.AddWithValue("@mensefreq", txtMenseFreq.Text);
                            cmd.Parameters.AddWithValue("@hx", txtHx.Text);
                            cmd.Parameters.AddWithValue("@medhistnotes", txtHistNotes.Text);
                            cmd.Parameters.AddWithValue("@pid", comboBox1.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (screenMode == 3)
                    {
                        string query = @"INSERT INTO generalmedicalhistory (
                    MaritalStatus, Education, BehavioralHistory, Tobacco, TobaccoDuraton, 
                    TobaccoQuantity, Alcohol, AlcoholDuration, AlcoholQuantity, Drug, 
                    DrugType, DrugDuration, Dietary, BloodType, Rh, 
                    NumberOfChildren, LMPStatus, MensesMonthlyYes, MensesMonthlyNo, 
                    MensesFreq, HxObtainedBy, MedicalHistoryNotes) 
                    VALUES (
                    @marital, @education, @behavioral, @tobacco, @tobaccodur, 
                    @tobaccoquan, @alc, @alcdur, @alcquan, @drug, 
                    @drugtype, @drugdur, @diet, @bloodtype, @rh, 
                    @childnum, @lmp, @mensesyes, @mensesno, 
                    @mensefreq, @hx, @medhistnotes)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@marital", txtMaritalStat.Text);
                            cmd.Parameters.AddWithValue("@education", txtEducation.Text);
                            cmd.Parameters.AddWithValue("@behavioral", txtBehavioral.Text);
                            cmd.Parameters.AddWithValue("@tobacco", txt_Tobacco.Text);
                            cmd.Parameters.AddWithValue("@tobaccodur", txt_TobaccoDur.Text);
                            cmd.Parameters.AddWithValue("@tobaccoquan", txt_TobaccoQuant.Text);
                            cmd.Parameters.AddWithValue("@alc", txtAlc.Text);
                            cmd.Parameters.AddWithValue("@alcdur", txtAlcDur.Text);
                            cmd.Parameters.AddWithValue("@alcquan", txtAlcQuant.Text);
                            cmd.Parameters.AddWithValue("@drug", txtDrug.Text);
                            cmd.Parameters.AddWithValue("@drugtype", txtDrugType.Text);
                            cmd.Parameters.AddWithValue("@drugdur", txtDrugDur.Text);
                            cmd.Parameters.AddWithValue("@diet", txtDiet.Text);
                            cmd.Parameters.AddWithValue("@bloodtype", txtBloodType.Text);
                            cmd.Parameters.AddWithValue("@rh", txtRH.Text);
                            cmd.Parameters.AddWithValue("@childnum", txtChildrenNum.Text);
                            cmd.Parameters.AddWithValue("@lmp", txtLMPStat.Text);
                            cmd.Parameters.AddWithValue("@mensesyes", txtMensesMonth.Text);
                            cmd.Parameters.AddWithValue("@mensesno", txtMensesNo.Text);
                            cmd.Parameters.AddWithValue("@mensefreq", txtMenseFreq.Text);
                            cmd.Parameters.AddWithValue("@hx", txtHx.Text);
                            cmd.Parameters.AddWithValue("@medhistnotes", txtHistNotes.Text);
                            cmd.Parameters.AddWithValue("@pid", comboBox1.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error performing operation: " + ex);
                }

                lockScreen();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.MakeConnection();

            using (conn)
            {
                try
                {
                    string query = "UPDATE generalmedicalhistory SET deleted = 1 WHERE GeneralMedicalHistoryID = @pid";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", comboBox1.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Deleting: " + ex);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Close();
            form.ShowDialog();
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            FamilyHistory form = new FamilyHistory(pid);
            this.Close(); 
            form.ShowDialog();
        }

        private void btnAllergy_Click(object sender, EventArgs e)
        {
            AllergyHistory form = new AllergyHistory(pid);
            this.Close();
            form.ShowDialog();
        }

        private void btnGenHist_Click(object sender, EventArgs e)
        {
            GeneralHistory form = new GeneralHistory(pid);
            this.Close();
            form.ShowDialog();
        }

        private void btnPatientDem_Click(object sender, EventArgs e)
        {
            PatientDemographics form = new PatientDemographics(pid);
            this.Close();
            form.ShowDialog();
        }

        private void btnSelPat_Click(object sender, EventArgs e)
        {
            Select_Patient form = new Select_Patient();
            this.Close();
            form.ShowDialog();
        }
    }
}
