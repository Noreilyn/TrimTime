using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TrimTime
{
    public partial class REGform : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public REGform()
        {
            InitializeComponent();
        }

        private void BACK_btn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            MAINform frm = new MAINform(); // Create a new instance of MAINform
            frm.Show(); 
        }

        private void REGISTER_btn_Click(object sender, EventArgs e)
        {
            string username = UN_inputreg.Text;
            string password = PW_inputreg.Text;
            string email = EM_inputreg.Text;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password, email) VALUES (@username, @password, @email)", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // Display MySQL exception message
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // Display general exception message
                }
            }
        }
    }
}
