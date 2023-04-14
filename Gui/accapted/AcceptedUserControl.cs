using collageProject.Gui.Cases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.accapted
{
    public partial class AcceptedUserControl : UserControl
    {
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        static private AcceptedUserControl _AcceptedUserControl;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";

        public AcceptedUserControl()
        {
            InitializeComponent();
            showTable();

            // add delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "حذف";
            deleteButton.UseColumnTextForButtonValue = true;

            // Set the button cell template to a new instance of DataGridViewButtonCell

            // Add the button column to the DataGridView
            tableAccepted.Columns.Add(deleteButton);

            // Handle the CellContentClick event to detect button clicks
            tableAccepted.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Delete" button
            if (tableAccepted.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Get the ID of the row to delete
                int id = (int)tableAccepted.Rows[e.RowIndex].Cells["id"].Value;

                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?"+id.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    deletsons(id);
                    // Delete the row from the database
                    string query = "DELETE FROM accepted WHERE id = @idValue;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idValue", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    // Remove the row from the DataGridView
                    tableAccepted.Rows.RemoveAt(e.RowIndex);

                    // Show a message box to indicate that the row has been deleted
                    MessageBox.Show("Row deleted successfully.");
                }
            }
        }

        private void deletsons(int id)
        {
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";

            string querySelecte = "delete from sons where id_accepted = @idvalue";

            // Create a connection to the database
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command with a parameter
            SqlCommand command = new SqlCommand(querySelecte, connection);
            command.Parameters.AddWithValue("@idvalue", id.ToString()); // set the value of the @idvalue parameter to 123

            // Open the connection
            connection.Open();

            // Execute the command and retrieve the result
            object result = command.ExecuteScalar();

            // Close the connection
            connection.Close();
           
        }
        private void showTable()
        {

            string query = "SELECT ac.id, a.first_name, a.last_name, ac.credit_card_number, ac.acceptance_date\r\nFROM applicants a\r\nINNER JOIN accepted ac ON a.id = ac.id_applicant;";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(this.casesTable);
            tableAccepted.DataSource = this.casesTable;
           
            // don't show the id 
            tableAccepted.Columns["Id"].Visible = false;

            //chanage name to arabic
             tableAccepted.Columns["last_name"].HeaderText= "الاسم الثاني";
            tableAccepted.Columns["first_name"].HeaderText = "الاسم الاول";
            tableAccepted.Columns["acceptance_date"].HeaderText = "تاريخ القبول";
            tableAccepted.Columns["credit_card_number"].HeaderText = "رقم بطاقة الائتمان";

            connection.Close();
        }

        public static AcceptedUserControl Instance()
        {
            return _AcceptedUserControl ?? (new AcceptedUserControl());
        }

      

        private void tableAccepted_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ParentForm.Visible = false; // hide the parent form
            AddAccepted addAccepted = new AddAccepted();
            addAccepted.ShowDialog();
            this.ParentForm.Visible = true;
        }
    }
}
