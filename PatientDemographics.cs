using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ITS245_FinalProject
{
    public partial class PatientDemographics : Form
    {
        MySqlConnection conn;

        int PID;
        DataTable dt;
        int screenmode = 1;
        public PatientDemographics(int pid)
        {
            InitializeComponent();
            PID = pid;
            txt_pid.Text = PID.ToString();
            lockText();
            MySqlConnection conn = DBUtils.MakeConnection();
            dt = DBUtils.GetAllPatientDemographicsSP(conn, PID);
            foreach (DataRow dr in dt.Rows)
            {
                txt_zip.Text = dr["HomeZip"].ToString();
                txt_address.Text = dr["HomeAddress"].ToString();
                txt_citizenship.Text = dr["Citizenship"].ToString();
                txt_city.Text = dr["HomeCity"].ToString();
                txt_country.Text = dr["Country"].ToString();
                txt_comment.Text = dr["Comments"].ToString();
                txt_dob.Text = dr["DOB"].ToString();
                txt_email.Text = dr["EmailAddress"].ToString();
                txt_emnum.Text = dr["EmergencyPhoneNumber"].ToString();
                txt_employment.Text = dr["EmploymentStatus"].ToString();
                txt_entered.Text = dr["DateEntered"].ToString();
                txt_ethnic.Text = dr["EthnicAssociation"].ToString();
                txt_expire.Text = dr["DateOfExpire"].ToString();
                txt_fname.Text = dr["PtFirstName"].ToString();
                txt_gender.Text = dr["Gender"].ToString();
                txt_hcp.Text = dr["CurrentPrimaryHCPId"].ToString();
                txt_kindID.Text = dr["NextOfKinId"].ToString();
                txt_kinRelation.Text = dr["NextOfKinRelationshipToPatient"].ToString();
                txt_lname.Text = dr["PtLastName"].ToString();
                txt_marital.Text = dr["MaritalStatus"].ToString();
                txt_mi.Text = dr["PtMiddleInitial"].ToString();
                txt_mr.Text = dr["HospitalMR"].ToString();
                txt_pnum.Text = dr["PtHomePhone"].ToString();
                txt_ref.Text = dr["Referral"].ToString();
                txt_religion.Text = dr["Religion"].ToString();
                txt_ssn.Text = dr["SSN"].ToString();
                txt_state.Text = dr["HomeState"].ToString();
                txt_suffix.Text = dr["Suffix"].ToString();
            }
        }

        public PatientDemographics()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_Patient frm1 = new Select_Patient();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AllergyHistory frm1 = new AllergyHistory(PID);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            unlockText();
            screenmode = 2;
            txt_pid.Text = "";
            txt_address.Text = "";
            txt_citizenship.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_comment.Text = "";
            txt_dob.Text = "";
            txt_email.Text = "";
            txt_emnum.Text = "";
            txt_employment.Text = "";
            txt_entered.Text = "";
            txt_ethnic.Text = "";
            txt_expire.Text = "";
            txt_fname.Text = "";
            txt_gender.Text = "";
            txt_hcp.Text = "";
            txt_kindID.Text = "";
            txt_kinRelation.Text = "";
            txt_lname.Text = "";
            txt_marital.Text = "";
            txt_mi.Text = "";
            txt_mr.Text = "";
            txt_pnum.Text = "";
            txt_ref.Text = "";
            txt_religion.Text = "";
            txt_ssn.Text = "";
            txt_state.Text = "";
            txt_suffix.Text = "";
            txt_zip.Text = "";
            btn_save.Enabled = true;
            btn_undo.Enabled = true;
        }
        public void lockText()
        {
            pnl_main.BackColor = Color.Gray;
            txt_address.Enabled = false;
            txt_citizenship.Enabled = false;
            txt_city.Enabled = false;
            txt_country.Enabled = false;
            txt_comment.Enabled = false;
            txt_dob.Enabled = false;
            txt_email.Enabled = false;
            txt_emnum.Enabled = false;
            txt_employment.Enabled = false;
            txt_entered.Enabled = false;
            txt_ethnic.Enabled = false;
            txt_expire.Enabled = false;
            txt_fname.Enabled = false;
            txt_gender.Enabled = false;
            txt_hcp.Enabled = false;
            txt_kindID.Enabled = false;
            txt_kinRelation.Enabled = false;
            txt_lname.Enabled = false;
            txt_marital.Enabled = false;
            txt_mi.Enabled = false;
            txt_mr.Enabled = false;
            txt_pnum.Enabled = false;
            txt_ref.Enabled = false;
            txt_religion.Enabled = false;
            txt_ssn.Enabled = false;
            txt_state.Enabled = false;
            txt_suffix.Enabled = false;
            txt_pid.Enabled = false;
            txt_zip.Enabled = false;

        }
        public void unlockText()
        {
            pnl_main.BackColor = Color.Blue;
            txt_address.Enabled = true;
            txt_citizenship.Enabled = true;
            txt_city.Enabled = true;
            txt_country.Enabled = true;
            txt_comment.Enabled = true;
            txt_dob.Enabled = true;
            txt_email.Enabled = true;
            txt_emnum.Enabled = true;
            txt_employment.Enabled = true;
            txt_entered.Enabled = true;
            txt_ethnic.Enabled = true;
            txt_expire.Enabled = true;
            txt_fname.Enabled = true;
            txt_gender.Enabled = true;
            txt_hcp.Enabled = true;
            txt_kindID.Enabled = true;
            txt_kinRelation.Enabled = true;
            txt_lname.Enabled = true;
            txt_marital.Enabled = true;
            txt_mi.Enabled = true;
            txt_mr.Enabled = true;
            txt_pnum.Enabled = true;
            txt_ref.Enabled = true;
            txt_religion.Enabled = true;
            txt_ssn.Enabled = true;
            txt_state.Enabled = true;
            txt_suffix.Enabled = true;
            txt_pid.Enabled = true;
            txt_zip.Enabled = true;
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            unlockText();
            btn_save.Enabled = true;
            screenmode = 3;
            btn_undo.Enabled = true;

        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            lockText();
            MySqlConnection conn = DBUtils.MakeConnection();
            dt = DBUtils.GetAllPatientDemographicsSP(conn, PID);
            foreach (DataRow dr in dt.Rows)
            {
                txt_state.Text = dr["HomeState"].ToString();
                txt_zip.Text = dr["HomeZip"].ToString();
                txt_address.Text = dr["HomeAddress"].ToString();
                txt_citizenship.Text = dr["Citizenship"].ToString();
                txt_city.Text = dr["HomeCity"].ToString();
                txt_country.Text = dr["Country"].ToString();
                txt_comment.Text = dr["Comments"].ToString();
                txt_dob.Text = dr["DOB"].ToString();
                txt_email.Text = dr["EmailAddress"].ToString();
                txt_emnum.Text = dr["EmergencyPhoneNumber"].ToString();
                txt_employment.Text = dr["EmploymentStatus"].ToString();
                txt_entered.Text = dr["DateEntered"].ToString();
                txt_ethnic.Text = dr["EthnicAssociation"].ToString();
                txt_expire.Text = dr["DateOfExpire"].ToString();
                txt_fname.Text = dr["PtFirstName"].ToString();
                txt_gender.Text = dr["Gender"].ToString();
                txt_hcp.Text = dr["CurrentPrimaryHCPId"].ToString();
                txt_kindID.Text = dr["NextOfKinId"].ToString();
                txt_kinRelation.Text = dr["NextOfKinRelationshipToPatient"].ToString();
                txt_lname.Text = dr["PtLastName"].ToString();
                txt_marital.Text = dr["MaritalStatus"].ToString();
                txt_mi.Text = dr["PtMiddleInitial"].ToString();
                txt_mr.Text = dr["HospitalMR"].ToString();
                txt_pnum.Text = dr["PtHomePhone"].ToString();
                txt_ref.Text = dr["Referral"].ToString();
                txt_religion.Text = dr["Religion"].ToString();
                txt_ssn.Text = dr["SSN"].ToString();
                txt_suffix.Text = dr["Suffix"].ToString();
                txt_pid.Text = PID.ToString();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.MakeConnection();
            if (screenmode == 2)
            {

                try
                {
                    if (!string.IsNullOrEmpty(txt_lname.Text)) { 
                    MySqlCommand cmd = new MySqlCommand("AddPatientSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PID", txt_pid.Text);
                    cmd.Parameters.AddWithValue("@MR", txt_mr.Text);
                    cmd.Parameters.AddWithValue("@LName", txt_lname.Text);
                    cmd.Parameters.AddWithValue("@fName", txt_fname.Text);
                    cmd.Parameters.AddWithValue("@PMI", txt_mi.Text);
                    cmd.Parameters.AddWithValue("@suf", txt_suffix.Text);
                    cmd.Parameters.AddWithValue("@addy", txt_address.Text);
                    cmd.Parameters.AddWithValue("@city", txt_city.Text);
                    cmd.Parameters.AddWithValue("@state", txt_state.Text);
                    cmd.Parameters.AddWithValue("@zip", txt_zip.Text);
                    cmd.Parameters.AddWithValue("@country", txt_country.Text);
                    cmd.Parameters.AddWithValue("@citizen", txt_citizenship.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_pnum.Text);
                    cmd.Parameters.AddWithValue("@ephone", txt_emnum.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@ssn", txt_ssn.Text);
                    cmd.Parameters.AddWithValue("@birth", txt_dob.Text);
                    cmd.Parameters.AddWithValue("@gend", txt_gender.Text);
                    cmd.Parameters.AddWithValue("@ethnic", txt_ethnic.Text);
                    cmd.Parameters.AddWithValue("@rel", txt_religion.Text);
                    cmd.Parameters.AddWithValue("@married", txt_marital.Text);
                    cmd.Parameters.AddWithValue("@employ", txt_employment.Text);
                    cmd.Parameters.AddWithValue("@DOE", txt_expire.Text);
                    cmd.Parameters.AddWithValue("@ref", txt_ref.Text);
                    cmd.Parameters.AddWithValue("@hcp", txt_hcp.Text);
                    cmd.Parameters.AddWithValue("@comm", txt_comment.Text);
                    cmd.Parameters.AddWithValue("@enter", txt_entered.Text);
                    cmd.Parameters.AddWithValue("@kinID", txt_kindID.Text);
                    cmd.Parameters.AddWithValue("@kinrel", txt_kinRelation.Text);
                        PID = Convert.ToInt32(txt_pid.Text);
                    int recsReturned = cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted " + recsReturned + " records into Patient table!");
                        screenmode = 1;
                        btn_save.Enabled = false;
                        lockText();
                        dt = DBUtils.GetAllPatientDemographicsSP(conn, PID);
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_state.Text = dr["HomeState"].ToString();
                            txt_zip.Text = dr["HomeZip"].ToString();
                            txt_address.Text = dr["HomeAddress"].ToString();
                            txt_citizenship.Text = dr["Citizenship"].ToString();
                            txt_city.Text = dr["HomeCity"].ToString();
                            txt_country.Text = dr["Country"].ToString();
                            txt_comment.Text = dr["Comments"].ToString();
                            txt_dob.Text = dr["DOB"].ToString();
                            txt_email.Text = dr["EmailAddress"].ToString();
                            txt_emnum.Text = dr["EmergencyPhoneNumber"].ToString();
                            txt_employment.Text = dr["EmploymentStatus"].ToString();
                            txt_entered.Text = dr["DateEntered"].ToString();
                            txt_ethnic.Text = dr["EthnicAssociation"].ToString();
                            txt_expire.Text = dr["DateOfExpire"].ToString();
                            txt_fname.Text = dr["PtFirstName"].ToString();
                            txt_gender.Text = dr["Gender"].ToString();
                            txt_hcp.Text = dr["CurrentPrimaryHCPId"].ToString();
                            txt_kindID.Text = dr["NextOfKinId"].ToString();
                            txt_kinRelation.Text = dr["NextOfKinRelationshipToPatient"].ToString();
                            txt_lname.Text = dr["PtLastName"].ToString();
                            txt_marital.Text = dr["MaritalStatus"].ToString();
                            txt_mi.Text = dr["PtMiddleInitial"].ToString();
                            txt_mr.Text = dr["HospitalMR"].ToString();
                            txt_pnum.Text = dr["PtHomePhone"].ToString();
                            txt_ref.Text = dr["Referral"].ToString();
                            txt_religion.Text = dr["Religion"].ToString();
                            txt_ssn.Text = dr["SSN"].ToString();
                            txt_suffix.Text = dr["Suffix"].ToString();
                            txt_pid.Text = PID.ToString();
                        }
                    }
                    else { MessageBox.Show("Please enter a last name"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert of Allergen Failed!  Message=" + ex.Message);
                }
            }
            else if(screenmode == 3)
            {
                try
                {
                    if (!string.IsNullOrEmpty(txt_lname.Text))
                    {
                        MySqlCommand cmd = new MySqlCommand("UpdatePatientSP", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PID", txt_pid.Text);
                        cmd.Parameters.AddWithValue("@MR", txt_mr.Text);
                        cmd.Parameters.AddWithValue("@LName", txt_lname.Text);
                        cmd.Parameters.AddWithValue("@fName", txt_fname.Text);
                        cmd.Parameters.AddWithValue("@PMI", txt_mi.Text);
                        cmd.Parameters.AddWithValue("@suf", txt_suffix.Text);
                        cmd.Parameters.AddWithValue("@addy", txt_address.Text);
                        cmd.Parameters.AddWithValue("@city", txt_city.Text);
                        cmd.Parameters.AddWithValue("@state", txt_state.Text);
                        cmd.Parameters.AddWithValue("@zip", txt_zip.Text);
                        cmd.Parameters.AddWithValue("@n_country", txt_country.Text);
                        cmd.Parameters.AddWithValue("@citizen", txt_citizenship.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_pnum.Text);
                        cmd.Parameters.AddWithValue("@ephone", txt_emnum.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@n_ssn", txt_ssn.Text);
                        cmd.Parameters.AddWithValue("@birth", txt_dob.Text);
                        cmd.Parameters.AddWithValue("@gend", txt_gender.Text);
                        cmd.Parameters.AddWithValue("@ethnic", txt_ethnic.Text);
                        cmd.Parameters.AddWithValue("@rel", txt_religion.Text);
                        cmd.Parameters.AddWithValue("@married", txt_marital.Text);
                        cmd.Parameters.AddWithValue("@employ", txt_employment.Text);
                        cmd.Parameters.AddWithValue("@DOE", txt_expire.Text);
                        cmd.Parameters.AddWithValue("@ref", txt_ref.Text);
                        cmd.Parameters.AddWithValue("@hcp", txt_hcp.Text);
                        cmd.Parameters.AddWithValue("@comm", txt_comment.Text);
                        cmd.Parameters.AddWithValue("@enter", txt_entered.Text);
                        cmd.Parameters.AddWithValue("@kinID", txt_kindID.Text);
                        cmd.Parameters.AddWithValue("@kinrel", txt_kinRelation.Text);
                        PID = Convert.ToInt32(txt_pid.Text);
                        int recsReturned = cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated " + recsReturned + " records into Patient table!");
                        screenmode = 1;
                        btn_save.Enabled = false;
                        lockText();
                        dt = DBUtils.GetAllPatientDemographicsSP(conn, PID);
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_state.Text = dr["HomeState"].ToString();
                            txt_zip.Text = dr["HomeZip"].ToString();
                            txt_address.Text = dr["HomeAddress"].ToString();
                            txt_citizenship.Text = dr["Citizenship"].ToString();
                            txt_city.Text = dr["HomeCity"].ToString();
                            txt_country.Text = dr["Country"].ToString();
                            txt_comment.Text = dr["Comments"].ToString();
                            txt_dob.Text = dr["DOB"].ToString();
                            txt_email.Text = dr["EmailAddress"].ToString();
                            txt_emnum.Text = dr["EmergencyPhoneNumber"].ToString();
                            txt_employment.Text = dr["EmploymentStatus"].ToString();
                            txt_entered.Text = dr["DateEntered"].ToString();
                            txt_ethnic.Text = dr["EthnicAssociation"].ToString();
                            txt_expire.Text = dr["DateOfExpire"].ToString();
                            txt_fname.Text = dr["PtFirstName"].ToString();
                            txt_gender.Text = dr["Gender"].ToString();
                            txt_hcp.Text = dr["CurrentPrimaryHCPId"].ToString();
                            txt_kindID.Text = dr["NextOfKinId"].ToString();
                            txt_kinRelation.Text = dr["NextOfKinRelationshipToPatient"].ToString();
                            txt_lname.Text = dr["PtLastName"].ToString();
                            txt_marital.Text = dr["MaritalStatus"].ToString();
                            txt_mi.Text = dr["PtMiddleInitial"].ToString();
                            txt_mr.Text = dr["HospitalMR"].ToString();
                            txt_pnum.Text = dr["PtHomePhone"].ToString();
                            txt_ref.Text = dr["Referral"].ToString();
                            txt_religion.Text = dr["Religion"].ToString();
                            txt_ssn.Text = dr["SSN"].ToString();
                            txt_suffix.Text = dr["Suffix"].ToString();
                            txt_pid.Text = PID.ToString();
                        }
                    }
                    else { MessageBox.Show("Please enter a last name"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update of Patient Failed!  Message=" + ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update patientdemographics Set DELETED = 1 WHERE PatientID = '" + PID + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Please select new patient now.");
                    Select_Patient frm1 = new Select_Patient();
                    this.Hide();
                    frm1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Operation failed to Patient Table", ex.Message);
                }
            }
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            PatientDemographics frm1 = new PatientDemographics(PID);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_genHist_Click(object sender, EventArgs e)
        {
            GeneralHistory frm1 = new GeneralHistory();
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_famHist_Click(object sender, EventArgs e)
        {
            FamilyHistory frm1 = new FamilyHistory();
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.ShowDialog();
        }
    }
    }
