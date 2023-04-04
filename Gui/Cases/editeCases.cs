using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Bogus.DataSets.Name;

namespace collageProject.Gui.Cases
{
    public partial class editeCases : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        string Id;
        public editeCases(string id,string name ,string gender ,string desc)
        {
            InitializeComponent();

            // Set the textbox values
            nameTextbox.Text = name;
            genderTextbox.Text = gender;
            descraptionTextbox.Text = desc;
            
            Id = id;



        }

        private void editebutton_Click(object sender, EventArgs e)
        {
            // Create the connection and adapter objects
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = "UPDATE cases SET Gender = @genderValue, Name = @nameValue, description = @descValue WHERE ID = @idValue;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            // Create the command object and add parameters
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@genderValue", genderTextbox.Text);
            command.Parameters.AddWithValue("@nameValue",nameTextbox.Text );
            command.Parameters.AddWithValue("@descValue", descraptionTextbox.Text);
            command.Parameters.AddWithValue("@idValue", Id);

            // Open the connection, execute the query, and close the connection
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
            
        }
    }
}
