using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.Cases
{
    
    public partial class AddCases : Form

    {   private SqlConnection connection;
       private SqlDataAdapter adapter;
        public AddCases()
        {
            InitializeComponent();


        }
       

        private int GetNewId()
        {
            int newId = 0;
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = "SELECT MAX(ID) FROM cases;"; // Get the maximum existing ID in the table
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

        private void addrow()
        {

            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = "INSERT INTO cases (ID, Gender, Name, description) VALUES (@idValue, @genderValue, @nameValue, @descValue);";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            // Create the command object and add parameters
            SqlCommand command = new SqlCommand(query, connection);
            int newId = GetNewId(); // Get a new ID for the row
            command.Parameters.AddWithValue("@idValue", newId);
            command.Parameters.AddWithValue("@genderValue", genderTextbox.Text);
            command.Parameters.AddWithValue("@nameValue", nameTextbox.Text);
            command.Parameters.AddWithValue("@descValue", descraptionTextbox.Text);

            // Open the connection, execute the query, and close the connection
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void saveExit_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text.Length > 0 && descraptionTextbox.Text.Length > 0 && genderTextbox.Text.Length > 0)
            {
                addrow();
                nameTextbox.Text = "";
                descraptionTextbox.Text = "";
                genderTextbox.Text = ""; 
                this.Close();
            }
            else
            {
                if (nameTextbox.Text.Length <= 0)
                    MessageBox.Show("يجب ان تكتب اسم الحالة");
                else if (descraptionTextbox.Text.Length <= 0)
                    MessageBox.Show("يجب ان تكتب التفاصيل");
                else
                    MessageBox.Show("يجب ان تكتب الجنس");
            }

          
        }


        private void save_Click(object sender, EventArgs e)
        {   

            if (nameTextbox.Text.Length> 0 && descraptionTextbox.Text.Length > 0 && genderTextbox.Text.Length>0)
            {
                addrow();
                nameTextbox.Text = "";
                descraptionTextbox.Text = "";
                genderTextbox.Text = "";
            }
            else
            {
                if ( nameTextbox.Text.Length <=0)
                MessageBox.Show("يجب ان تكتب اسم الحالة");
                else if (descraptionTextbox.Text.Length<=0)
                    MessageBox.Show("يجب ان تكتب التفاصيل");
                else
                    MessageBox.Show("يجب ان تكتب الجنس");
            }


            // Close the form
        }
    }
}
