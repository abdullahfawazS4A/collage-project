using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Bogus.DataSets.Name;

namespace collageProject.Gui.accapted
{
    public partial class AddToacceptedForm : Form
    {
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        string id_applicant;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public AddToacceptedForm(string id_applicant)
        {
            InitializeComponent();

            this.id_applicant = id_applicant;
           
        }

        private void credit_card_numbertextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Discard the input character
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            acceptance_datedateTimePicker1.Enabled = !checkBox1.Checked;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            string sql = $"INSERT INTO [dbo].[accepted] ([id], [credit_card_number], [acceptance_date],id_applicant,[credit_card_issuance_date]) " +
                $"VALUES ({GetNewId().ToString()}, '123423', '{acceptance_datedateTimePicker1.Value.Date}',{this.id_applicant},'{credit_card_issuance_datedateTimePicker2.Value.Date}')";
            SqlCommand command = new SqlCommand(sql, connection);

            // open the connection and execute the command
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            updateApplicanttoadded();
            this.Close();
        }
        private void updateApplicanttoadded()
        {

            connection = new SqlConnection(connectionString);

            string sql = $"update applicants set added =1  where id = {this.id_applicant}";
            SqlCommand command = new SqlCommand(sql, connection);

            // open the connection and execute the command
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private int GetNewId()
        {
            int newId = 0;
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = "SELECT MAX(ID) FROM accepted;"; // Get the maximum existing ID in the table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    newId = Convert.ToInt32(result) + 1; // Increment the maximum ID by 1 to get a new ID
                }
                connection.Close();
            }
            return newId;
        }
    }
}
