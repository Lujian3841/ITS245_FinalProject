using MySql.Data.MySqlClient;
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

namespace ITS245_FinalProject
{
    public partial class AllergyHistory : Form
    {
        MySqlConnection conn;
        DataTable dt;
        int pid;
        string allergy;
        int returnedRecs = 0;
        int screenmode = 1;
        public AllergyHistory(int PID)
        {
            InitializeComponent();
            this.pid = PID;
            txt_pid.Text = pid.ToString();
            //btnGetAllPatients_Click(this, new EventArgs());
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    dt = DBUtils.GetAllergys(conn, pid);
                    PatientView.DataSource = dt;
                   this.PatientView.Columns["AllergyID"].Visible = false;
                    this.PatientView.Columns["AllergyStartDate"].Visible = false;
                    this.PatientView.Columns["AllergyEndDate"].Visible = false;
                    this.PatientView.Columns["AllergyDescription"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to Patient Table", ex.Message);
                }
            }
            
        }
        private void PatientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = PatientView.CurrentCell.RowIndex;
            allergy = PatientView[0, rowIndex].FormattedValue.ToString();
            txt_allergen.Text = PatientView[0, rowIndex].FormattedValue.ToString();
            textBox2.Text = PatientView[1, rowIndex].FormattedValue.ToString();
            textBox27.Text = PatientView[2, rowIndex].FormattedValue.ToString();
            textBox25.Text = PatientView[3, rowIndex].FormattedValue.ToString();
            textBox1.Text = PatientView[4, rowIndex].FormattedValue.ToString();
        }
        private void AllergyHistory_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    dt = DBUtils.GetAllergys(conn, pid);
                    PatientView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to Patient Table", ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox25.Enabled = true;
            textBox27.Enabled = true;
            textBox1.Enabled = true;
            txt_allergen.Enabled = true;
            panel2.BackColor = Color.Blue;
            screenmode = 2;
            button14.Enabled = true;
            textBox2.Text = "";
            textBox25.Text = "";
            textBox27.Text = "";
            textBox1.Text = "";
            txt_allergen.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox25.Enabled = true;
            textBox27.Enabled = true;
            textBox1.Enabled = true;
            panel2.BackColor = Color.Blue;
            screenmode = 3;
            button14.Enabled = true;
            txt_allergen.Enabled= true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(screenmode == 2)
            {
                if (!string.IsNullOrEmpty(txt_allergen.Text))
                {
                    Allergen a = new Allergen();
                    a.AllergenID = Convert.ToInt32(textBox2.Text);
                    a.allergen = txt_allergen.Text;
                    a.AllergenStart = textBox27.Text;
                    a.AllergenEnd = textBox25.Text;
                    a.AllergenDescription = textBox1.Text;
                    a.PID = pid;
                    try
                    {
                        using (conn = DBUtils.MakeConnection())
                        {
                            int recsReturned = DBUtils.InsertAllergenSP(conn, a);
                            MessageBox.Show("Inserted " + recsReturned + " records into Patient table!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insert Patient Failed.  Message=" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter an Allergen!");
                }
            }
            else if(screenmode == 3)
            {
                if (!string.IsNullOrEmpty(txt_allergen.Text))
                {
                    Allergen a = new Allergen();
                    a.AllergenID = Convert.ToInt32(textBox2.Text);
                    a.allergen = txt_allergen.Text;
                    a.AllergenStart = textBox27.Text;
                    a.AllergenEnd = textBox25.Text;
                    a.AllergenDescription = textBox1.Text;
                    a.PID = pid;
                    try
                    {
                        using (conn = DBUtils.MakeConnection())
                        {
                            int recsReturned = DBUtils.UpdateAllergySP(conn, a);
                            MessageBox.Show("Updated " + recsReturned + " records into Patient table!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Patient Failed.  Message=" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter an Allergen!");
                }
            }
            textBox2.Enabled = false;
            textBox25.Enabled = false;
            textBox27.Enabled = false;
            textBox1.Enabled = false;
            panel2.BackColor = Color.Gray;
            screenmode = 1;
            button14.Enabled = false;
            txt_allergen.Enabled = false;
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    dt = DBUtils.GetAllergys(conn, pid);
                    PatientView.DataSource = dt;
                    this.PatientView.Columns["AllergyID"].Visible = false;
                    this.PatientView.Columns["AllergyStartDate"].Visible = false;
                    this.PatientView.Columns["AllergyEndDate"].Visible = false;
                    this.PatientView.Columns["AllergyDescription"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to Patient Table", ex.Message);
                }
            }
        }

        private void PatientView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = PatientView.CurrentCell.RowIndex;
            allergy = PatientView[0, rowIndex].FormattedValue.ToString();
            txt_allergen.Text = PatientView[0, rowIndex].FormattedValue.ToString();
            textBox2.Text = PatientView[1, rowIndex].FormattedValue.ToString();
            textBox27.Text = PatientView[2, rowIndex].FormattedValue.ToString();
            textBox25.Text = PatientView[3, rowIndex].FormattedValue.ToString();
            textBox1.Text = PatientView[4, rowIndex].FormattedValue.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Update allergyhistory Set DELETED = 1 WHERE Allergen = '"+allergy+"'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Operation failed to Patient Table", ex.Message);
                }
            }
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    dt = DBUtils.GetAllergys(conn, pid);
                    PatientView.DataSource = dt;
                    this.PatientView.Columns["AllergyID"].Visible = false;
                    this.PatientView.Columns["AllergyStartDate"].Visible = false;
                    this.PatientView.Columns["AllergyEndDate"].Visible = false;
                    this.PatientView.Columns["AllergyDescription"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB Operation failed to Patient Table", ex.Message);
                }
            }
            textBox2.Text = "";
            textBox25.Text = "";
            textBox27.Text = "";
            textBox1.Text = "";
            txt_allergen.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowIndex = PatientView.CurrentCell.RowIndex;
            allergy = PatientView[0, rowIndex].FormattedValue.ToString();
            txt_allergen.Text = PatientView[0, rowIndex].FormattedValue.ToString();
            textBox2.Text = PatientView[1, rowIndex].FormattedValue.ToString();
            textBox27.Text = PatientView[2, rowIndex].FormattedValue.ToString();
            textBox25.Text = PatientView[3, rowIndex].FormattedValue.ToString();
            textBox1.Text = PatientView[4, rowIndex].FormattedValue.ToString();
            textBox2.Enabled = false;
            textBox25.Enabled = false;
            textBox27.Enabled = false;
            textBox1.Enabled = false;
            panel2.BackColor = Color.Gray;
            screenmode = 1;
            button14.Enabled = false;
            txt_allergen.Enabled = false;
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

        private void btn_genHistory_Click(object sender, EventArgs e)
        {
            GeneralHistory frm1 = new GeneralHistory();
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_allergy_Click(object sender, EventArgs e)
        {
            AllergyHistory frm1 = new AllergyHistory(pid);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btn_famhist_Click(object sender, EventArgs e)
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

        public  AllergyHistory()
        {
            InitializeComponent();
        }
    }
    }
