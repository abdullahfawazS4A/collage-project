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
        string id_applicant;
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
                 this.id_applicant = tableAccepted.Rows[e.RowIndex].Cells["id_applicant"].Value.ToString();
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?"+this.id_applicant.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    updateApplicanttoadded();
                    // Show a message box to indicate that the row has been deleted
                    MessageBox.Show("Row deleted successfully.");
                    
                }
            }
        }

        private void updateApplicanttoadded()
        {

            connection = new SqlConnection(connectionString);

            string sql = $"update applicants set added =0  where id = {this.id_applicant}";
            SqlCommand command = new SqlCommand(sql, connection);

            // open the connection and execute the command
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
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

            string query = "SELECT ac.id, ac.id_applicant, a.first_name,a.second_name, a.last_name, ac.credit_card_number, ac.acceptance_date\r\nFROM applicants a\r\nINNER JOIN accepted ac ON a.id = ac.id_applicant;";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(this.casesTable);
            tableAccepted.DataSource = this.casesTable;
           
            // don't show the id 
            tableAccepted.Columns["Id"].Visible = false;
            tableAccepted.Columns["id_applicant"].Visible = false;
            //chanage name to arabic
            tableAccepted.Columns["last_name"].HeaderText= "الاسم الجد";
            tableAccepted.Columns["first_name"].HeaderText = "الاسم الاول";
            tableAccepted.Columns["acceptance_date"].HeaderText = "تاريخ القبول";
            tableAccepted.Columns["credit_card_number"].HeaderText = "رقم بطاقة الائتمان";
            tableAccepted.Columns["second_name"].HeaderText = "اسم الاب ";
            connection.Close();
        }

        public static AcceptedUserControl Instance()
        {
            return _AcceptedUserControl ?? (new AcceptedUserControl());
        }

      

        private void tableAccepted_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowNumber = e.RowIndex;
            DataGridViewRow row = tableAccepted.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[1].Value.ToString();
            string id_applicant = row.Cells[2].Value.ToString();
            this.ParentForm.Visible = false; // hide the parent form
            AddAccepted addAccepted = new AddAccepted(id, id_applicant);
            addAccepted.ShowDialog();
            this.ParentForm.Visible = true;

            showTable();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)


        {



            string query = "SELECT ac.id, a.first_name, a.last_name, ac.credit_card_number, ac.acceptance_date" +
                " FROM applicants a INNER JOIN accepted ac ON a.id = ac.id_applicant WHERE a.first_name LIKE '%"+ searchtextBox.Text+"%' or a.last_name LIKE '%"+searchtextBox.Text+"%';";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);
            tableAccepted.DataSource = casesTable;
            tableAccepted.Columns["Id"].Visible = false;

            connection.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddapplicantsForm addapplicants = new AddapplicantsForm();
            this.ParentForm.Visible = false;
            addapplicants.ShowDialog();

            showTable();

            this.ParentForm.Visible = true;

        }
    }
}
