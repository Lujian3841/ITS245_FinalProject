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
    public partial class FamilyHistory : Form
    {
        int pid;
        public FamilyHistory()
        {
            InitializeComponent();
        }

        public FamilyHistory(int PID)
        {
            InitializeComponent();
            this.pid = PID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboPatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            familyListBox.Items.Clear();

            string pid = comboPatID.SelectedItem.ToString();

            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT FamilyID FROM familyhistory WHERE PatientID = @pid";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pid);
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            familyListBox.Items.Add(reader["FamilyID"].ToString());
                        }
                    }
                }
            }
        }

        private void btnRelation_Click(object sender, EventArgs e)
        {
            var selectedItem = familyListBox.SelectedItem;

            txtAlive.Clear();
            txtDisorder.Clear();
            txtDisorderType.Clear();
            txtLivesWPat.Clear();
            txtName.Clear();
            txtRelation.Clear();

            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT Relation, Name, Alive, 'Lives with patient' FROM familyhistory WHERE FamilyID = @selectedItem";

                using (MySqlCommand cmd = new MySqlCommand (query, conn))
                {
                    if(selectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@selecteditem", selectedItem.ToString());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                          if (reader.Read())
                            {
                             txtRelation.Text = reader["Relation"].ToString();
                             txtName.Text = reader["Name"].ToString();
                             txtAlive.Text = reader["Alive"].ToString();
                             txtLivesWPat.Text = reader["Lives with patient"].ToString();
                            }
                        }
                    }
                    
                }
            }
        }

        private void btnDisorder_Click(object sender, EventArgs e)
        {
            txtAlive.Clear();
            txtDisorder.Clear();
            txtDisorderType.Clear();
            txtLivesWPat.Clear();
            txtName.Clear();
            txtRelation.Clear();

            var selectedItem = familyListBox.SelectedItem;
            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT Name, Alive, MajorDisorder, SpecificTypeDisorder FROM familyhistory WHERE FamilyID = @selectedItem";
                using(MySqlCommand cmd = new MySqlCommand (query, conn))
                {
                    cmd.Parameters.AddWithValue("@selecteditem", selectedItem);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtAlive.Text = reader["Alive"].ToString();
                            txtDisorder.Text = reader["MajorDisorder"].ToString();
                            txtDisorderType.Text = reader["SpecificTypeDisorder"].ToString();
                        }
                    }
                }
            }
        }

        private void FamilyHistory_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT DISTINCT PatientID FROM familyhistory";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboPatID.Items.Add(reader["PatientID"].ToString().Trim());
                        }
                    }
                }
            }

            patientLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
