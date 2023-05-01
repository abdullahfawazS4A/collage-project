using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.sons
{
    public partial class EditeForm : Form
    {
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string Id;
        public EditeForm(string Id)
        {
            InitializeComponent();
            this.Id = Id;
            fillcomvboxCases();
            full_nametextBox1.Text = GetData()["full_name"].ToString();
            birthdaydateTimePicker1.Text = GetData()["birthday"].ToString() ;

            mothers_nametextBox3.Text = GetData()["mothers_name"].ToString();
            gendercomboBox1.Text = GetData()["gender"].ToString();
           educational_attainmenttextBox4.Text = GetData()["educational_attainment"].ToString();
            place_of_birthdaytextBox5.Text = GetData()["place_of_birthday"].ToString();
            identification_numbertextBox8.Text =  GetData()["identification_number"].ToString();
            FhcomboBox2.Text = GetData()["name"].ToString();

        }
        private void fillcomvboxCases()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define a SQL SELECT statement to retrieve data from the table
                string query = "SELECT [ID], [Name] FROM [family_head] ";

                // Create a new SqlCommand object to execute the SQL statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the database connection
                    connection.Open();

                    // Execute the SQL statement and retrieve the data using a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the data and add each item to the ComboBox control
                        while (reader.Read())
                        {
                            FhcomboBox2.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private DataRow GetData()
        {

            string query = $"SELECT *  FROM sons inner join family_head on head_family_id = family_head.id where sons.id ={this.Id}";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            DataRow row = casesTable.Rows[0];

            // Access a column by name
            return row;

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
                string query = "UPDATE sons SET " +
                    $"educational_attainment = '{educational_attainmenttextBox4.Text}'," +
                    $" gender = '{gendercomboBox1.Text}', " +
                   $"full_name = '{full_nametextBox1.Text}', " +
                    $"    birthday = '{birthdaydateTimePicker1.Value.Date}'," +
                    $" mothers_name = '{mothers_nametextBox3.Text}'," +
                    $" identification_number = '{identification_numbertextBox8.Text}'," +
                    $"   place_of_birthday = '{place_of_birthdaytextBox5.Text}'," +
                    $" head_family_id = {GetNameHead(FhcomboBox2.Text.ToString())}" +
                
                    $"where id = {this.Id}";
                    connection = new SqlConnection(connectionString);

                // Create the command object and add parameters
                SqlCommand command = new SqlCommand(query, connection);
                // Get a new ID for the row


                // Open the connection, execute the query, and close the connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("تم التحديث");
            this.Close();
        }
        private string GetNameHead(string name)
        {

            DataTable dataTable = new DataTable();
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = $"SELECT  id FROM family_head where name = N'{name}' ;"; // Get the maximum existing ID in the table
            SqlConnection connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];

            // Access a column by name
            string id = row["id"].ToString();
            return id;


        }
    }
}
