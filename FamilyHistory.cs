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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITS245_FinalProject
{
    public partial class FamilyHistory : Form
    {
        int pid;
        int screenMode = 1;
        
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
            int fid = Convert.ToInt16(familyListBox.SelectedItem);
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT * FROM familyhistory WHERE FamilyID = @fid and deleted = 0";
                try
                {
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fid", fid);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtAlive.Text = Convert.ToInt32(reader["Alive"]).ToString();
                                txtDisorder.Text = reader["MajorDisorder"].ToString();
                                txtLivesWPat.Text = Convert.ToInt32(reader["Lives with patient"]).ToString();
                                txtDisorderType.Text = reader["SpecificTypeDisorder"].ToString();
                                txtName.Text = reader["Name"].ToString();
                                txtRelation.Text = reader["Relation"].ToString();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Displaying All Info: " + ex);
                }
            }
        }

        private void comboPatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            familyListBox.Items.Clear();

            string pid = comboPatID.SelectedItem.ToString();

            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT FamilyID FROM familyhistory WHERE PatientID = @pid and deleted = 0";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Populating ComboBox: " + ex);
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
                string query = "SELECT Relation, Name, Alive, `Lives with patient` FROM familyhistory WHERE FamilyID = @selectedItem and deleted = 0";

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
                             txtAlive.Text = Convert.ToInt32(reader["Alive"]).ToString();
                             txtLivesWPat.Text = Convert.ToInt32(reader["Lives with patient"]).ToString();
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
                string query = "SELECT Name, Alive, MajorDisorder, SpecificTypeDisorder FROM familyhistory WHERE FamilyID = @selectedItem and deleted = 0";
                using(MySqlCommand cmd = new MySqlCommand (query, conn))
                {
                    cmd.Parameters.AddWithValue("@selecteditem", selectedItem);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtAlive.Text = Convert.ToInt32(reader["Alive"]).ToString();
                            txtDisorder.Text = reader["MajorDisorder"].ToString();
                            txtDisorderType.Text = reader["SpecificTypeDisorder"].ToString();
                        }
                    }
                }
            }
        }

        private void loadListBox()
        {
            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT FamilyID FROM familyhistory WHERE PatientID = @pid and deleted = 0";
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pid);
                    try
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                familyListBox.Items.Add(dr["FamilyID"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error populating lsitbox on load: " + ex);
                    }
                }
            }
        }

        private void FamilyHistory_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT DISTINCT PatientID FROM familyhistory WHERE deleted = 0";
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
            lockScreen();
            loadListBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void patientLabel()
        {
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT PtFirstName, PtLastName, PtMiddleInitial FROM patientdemographics WHERE PatientID = @pid and deleted = 0";

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

        private void lockScreen()
        {
            panel3.BackColor = Color.LightSlateGray;

            txtAlive.Enabled = false;
            txtDisorder.Enabled = false;
            txtDisorderType.Enabled = false;
            txtLivesWPat.Enabled = false;
            txtName.Enabled = false;
            txtRelation.Enabled = false;
        }

        private void unlockScreen()
        {
            panel3.BackColor = Color.AliceBlue;

            txtAlive.Enabled = true;
            txtDisorder.Enabled = true;
            txtDisorderType.Enabled = true;
            txtLivesWPat.Enabled = true;
            txtName.Enabled = true;
            txtRelation.Enabled = true;
        }

        private void familyListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int fid = Convert.ToInt16(familyListBox.SelectedItem);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Dispose();
            login.ShowDialog();
        }

        private void btnAllergy_Click(object sender, EventArgs e)
        {
            Form form = new AllergyHistory(pid);
            this.Dispose();
            form.ShowDialog();
        }

        private void btnGenHist_Click(object sender, EventArgs e)
        {
            Form form = new GeneralHistory(pid);
            this.Dispose();
            form.ShowDialog();
        }

        private void btnPatientDem_Click(object sender, EventArgs e)
        {
            Form form = new PatientDemographics(pid);
            this.Dispose();
            form.ShowDialog();
        }

        private void btnSelPat_Click(object sender, EventArgs e)
        {
            Form form = new Select_Patient();
            this.Dispose();
            form.ShowDialog();
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            Form form = new FamilyHistory(pid);
            this.Dispose();
            form.ShowDialog();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.MakeConnection())
            {
                try
                {
                    string query = "UPDATE familyhistory SET deleted = 1 WHERE FamilyID = @fid";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", familyListBox.SelectedItem);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record deleted successfully.");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error Deleting: " + ex);
                }
            }
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
                        string query = "UPDATE familyhistory " +
                                        "SET PatientID = @patient, " +
                                        "Name = @name, " +
                                        "Relation = @relation, " +
                                        "Alive = @alive, " +
                                        "Lives with patient = @live, " +
                                        "MajorDisorder = @dis, " +
                                        "SpecificTypeDisorder = @distype, " +
                                        "WHERE FamilyID = @fid and deleted = '0'";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@patient", comboPatID.Text);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@relation", txtRelation.Text);
                            cmd.Parameters.AddWithValue("@alive", txtAlive.Text);
                            cmd.Parameters.AddWithValue("@live", txtLivesWPat.Text);
                            cmd.Parameters.AddWithValue("@dis", txtDisorder.Text);
                            cmd.Parameters.AddWithValue("@distype", txtDisorderType.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (screenMode == 3)
                    {
                        string query = @"INSERT INTO familyhistory (PatientId, Name, Relation, Alive, `Lives with patient`, 
                                        MajorDisorder, SpecificTypeDisorder) 
                                        VALUES (@patient, @name, @relation, @alive, @live, @dis, @distype)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@patient", comboPatID.Text);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@relation", txtRelation.Text);
                            cmd.Parameters.AddWithValue("@alive", txtAlive.Text);
                            cmd.Parameters.AddWithValue("@live", txtLivesWPat.Text);
                            cmd.Parameters.AddWithValue("@dis", txtDisorder.Text);
                            cmd.Parameters.AddWithValue("@distype", txtDisorderType.Text);

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

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtAlive.Clear(); 
            txtDisorder.Clear(); 
            txtDisorderType.Clear();
            txtLivesWPat.Clear();
            txtName.Clear();
            txtRelation.Clear();

            lockScreen();
        }

        
    }
}
