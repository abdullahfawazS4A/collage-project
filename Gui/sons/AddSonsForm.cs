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
    public partial class AddSonsForm : Form
    {
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        string id;
        public AddSonsForm(string id)
        {
            InitializeComponent();
            fillcomvboxCases();
            this.id = id;
            full_nametextBox1.Text=GetNewID().ToString();
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string newId = GetNewID().ToString();
                string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
                string query = "INSERT INTO [DBCollageproject].[dbo].[sons] (id,[educational_attainment], [gender], [full_name], [birthday], [mothers_name], [identification_number], [place_of_birthday], [head_family_id], [id_accepted]) " +
                    $"VALUES ({newId},N'{educational_attainmenttextBox4.Text}', N'{gendercomboBox1.Text}', N'{full_nametextBox1.Text}', '{birthdaydateTimePicker1.Value.Date}', N'{mothers_nametextBox3.Text}', '{identification_numbertextBox8.Text}',N'{place_of_birthdaytextBox5.Text}',{GetNameHead(FhcomboBox2.Text.ToString())},{this.id});";
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

            MessageBox.Show("تم الاضافة");
            this.Close();
        }


        private int GetNewID()
        {
            int newId = 0;
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = $"SELECT MAX(id) FROM sons ;"; // Get the maximum existing ID in the table
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

        private string GetNameHead(string name)
        {
           
          DataTable dataTable= new DataTable();
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
