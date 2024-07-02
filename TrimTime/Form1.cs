using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using MySql.Data.MySqlClient;

namespace TrimTime
{
    public partial class MAINform : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public MAINform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string username = UN_input.Text;
            string password = PW_input.Text;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(1) FROM users WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); 

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    // Successful login
                    MessageBox.Show("Login successful!");

                    // Hide the login form
                    this.Hide();

                    // Show the appointment form
                    AppointmentForm appointmentForm = new AppointmentForm(username);
                    appointmentForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {

        }

        private void UN_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PW_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            REGform frm = new REGform();
            frm.Show();
        }
    }
}
