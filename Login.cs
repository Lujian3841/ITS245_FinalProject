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
    public partial class Login : Form
    {
        MySqlConnection conn;
        string logged_user;
        string username;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            using (conn = DBUtils.MakeConnection())
            {

            }
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (AuthenticateUser(username, password))
            {
                logged_user = username;
                MessageBox.Show($"Login Successful: {logged_user}");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (conn = DBUtils.MakeConnection())
            {
                string query = "SELECT username, password FROM login WHERE username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbUser = reader["Username"].ToString();
                            string dbPassword = reader["Password"].ToString();

                            if (dbUser == username &&  dbPassword == password)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
