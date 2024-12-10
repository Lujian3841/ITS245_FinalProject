using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        int pid;
        public Select_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    pid = Convert.ToInt32(txtPID.Text);
                    cmd.CommandText = "SELECT PTLastName  FROM patientdemographics Where PatientID =" + pid;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PatientLastName.Text = reader[0].ToString();
                    }
                    reader.Close();
                    patientID.Text = txtPID.Text;
                    pid = Convert.ToInt32(txtPID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to insert on patient Table", ex.Message);
                }
            }
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
            int rowIndex = PatientView.CurrentCell.RowIndex;
            patientID.Text = PatientView[0, rowIndex].FormattedValue.ToString();
            PatientLastName.Text = PatientView[1, rowIndex].FormattedValue.ToString();
            pid = Convert.ToInt32(patientID.Text);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    string pLastName = selLastName.Text;
                    PatientLastName.Text=pLastName;
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT PatientID  FROM patientdemographics Where PTLastName =" + "'"+pLastName+"'";
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pid = Convert.ToInt32(reader[0]);
                        patientID.Text = pid.ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to Patient Table", ex.Message);
                }
            }
        }

      

      

        private void button2_Click(object sender, EventArgs e)
        {
            Select_Patient frm1 = new Select_Patient();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PatientDemographics frm1 = new PatientDemographics(pid);
            this.Hide();
            frm1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GeneralHistory frm1 = new GeneralHistory();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AllergyHistory frm1 = new AllergyHistory(pid);
            this.Hide();
            frm1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FamilyHistory frm1 = new FamilyHistory();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            AllergyHistory frm1 = new AllergyHistory(pid);
            this.Hide();
            frm1.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            PatientDemographics frm1 = new PatientDemographics(pid);
            this.Hide();
            frm1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


    }
}
