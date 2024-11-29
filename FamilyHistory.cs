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
        string pid, fid;
        public FamilyHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = DBUtils.MakeConnection();
            //pid = comboPatID.Text;
            //fid = comboFamID.Text;

            //using (conn)
            //{
            //    string query = "SELECT * FROM familyhistory WHERE FamilyID = @fid or PatientID = @pid";

            //    using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@pid", pid);
            //        cmd.Parameters.AddWithValue("@fid", fid);

            //        using (MySqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                txtName.Text = reader["Name"].ToString();
            //                txtRelation.Text = reader["Relation"].ToString();
            //                txtAlive.Text = reader["Alive"].ToString();
            //                txtLivesWPat.Text = reader["Lives with patient"].ToString();
            //                txtDisorder.Text = reader["MajorDisorder"].ToString();
            //                txtDisorderType.Text = reader["SpecificTypeDisorder"].ToString();
            //            }
            //        }
            //    }
            //}

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

            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT Relation, Name, Alive, 'Lives with patient' FROM familyhistory WHERE FamilyID = @selectedItem";

                using (MySqlCommand cmd = new MySqlCommand (query, conn))
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

        private void btnDisorder_Click(object sender, EventArgs e)
        {
            var selectedItem = familyListBox.SelectedItem;
            using(MySqlConnection conn = DBUtils.MakeConnection())
            {
                string query = "SELECT Name, Alive, MajorDisorder, SpecificTypeDisorder FROM familyhistory";
                using(MySqlCommand cmd = new MySqlCommand (query, conn))
                {
                    cmd.Parameters.AddWithValue("@selecteditem", selectedItem);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

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
        }

        
    }
}
