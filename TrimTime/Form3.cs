using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrimTime
{
    public partial class AppointmentForm : Form
    {
        private string username;
        private string connectionString = "server=localhost;user id=root;password=00001234;database=trimtime;";

        public AppointmentForm(string username)
        {
            InitializeComponent();
            this.username = username;

            // Set the DateTimePicker format to include time
            dateTimePickerAppointment.Format = DateTimePickerFormat.Custom;
            dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd HH:mm";

            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT haircut_style, username, email, appointment_time FROM users", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAppointments.DataSource = dt;
            }
        }

        private void UN_input_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void apnt_subbtn_Click(object sender, EventArgs e)
        {
            string haircutStyle = HC_input.Text;
            DateTime appointmentTime = dateTimePickerAppointment.Value;
            string username = ""; 

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    MySqlCommand getEmailCmd = new MySqlCommand("SELECT email FROM users WHERE username=@username", con);
                    getEmailCmd.Parameters.AddWithValue("@username", username);
                    string email = getEmailCmd.ExecuteScalar()?.ToString();

                    // Insert the appointment
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (haircut_style, username, email, appointment_time) VALUES (@haircutStyle, @username, @email, @appointmentTime)", con);
                    cmd.Parameters.AddWithValue("@haircutStyle", haircutStyle);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment booked successfully!");
                    LoadAppointments(); 
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // MySQL error code for duplicate entry
                    {
                        MessageBox.Show("The selected time slot is already booked. Please choose another time.");
                    }
                    else
                    {
                        MessageBox.Show("MySQL Error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
