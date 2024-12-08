using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITS245_FinalProject
{
    public partial class PatientDemographics : Form
    {
        int PID;
        DataTable dt;
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
                txt_mr.Text = dr["HospitalMR#"].ToString();
                txt_pnum.Text = dr["PtHomePhone"].ToString();
                txt_ref.Text = dr["Referral"].ToString();
                txt_religion.Text = dr["Religion"].ToString();
                txt_ssn.Text = dr["SSN"].ToString();
                txt_state.Text = dr["HomeState/Province/Region"].ToString();
                txt_suffix.Text = dr["Suffix"].ToString();
            }
        }

        public PatientDemographics()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
        public void lockText()
        {
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
        }
        public void unlockText()
        {
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
        }
    }
}
