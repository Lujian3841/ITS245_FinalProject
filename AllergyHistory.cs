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
        public AllergyHistory(int PID)
        {
            InitializeComponent();
            this.pid = PID;
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
            textBox3.Text = PatientView[0, rowIndex].FormattedValue.ToString();
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
            panel2.BackColor = Color.Blue;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox25.Enabled = true;
            textBox27.Enabled = true;
            textBox1.Enabled = true;
            panel2.BackColor = Color.Blue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "commit";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Operation failed to Patient Table", ex.Message);
                }
            }
            textBox2.Enabled = false;
            textBox25.Enabled = false;
            textBox27.Enabled = false;
            textBox1.Enabled = false;
            panel2.BackColor = Color.Gray;
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
            textBox3.Text = PatientView[0, rowIndex].FormattedValue.ToString();
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "rollback";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Undo Operation failed to Patient Table", ex.Message);
                }
            }
        }
    }
}
