using System;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus.DataSets;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace collageProject.Gui.Cases
{
    public partial class CasesUserControl : UserControl
    {
        private static CasesUserControl _CasesUserControl;
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
       


           string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";

        public CasesUserControl()
        {
            InitializeComponent();
            // conect to server
            showTable();
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text= "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            // Set the button cell template to a new instance of DataGridViewButtonCell
           
            // Add the button column to the DataGridView
            dataGridView1.Columns.Add(deleteButton);

            // Handle the CellContentClick event to detect button clicks
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);



            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Delete" button
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Get the ID of the row to delete
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;

                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the row from the database
                    string query = "DELETE FROM cases WHERE ID = @idValue;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idValue", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Show a message box to indicate that the row has been deleted
                    MessageBox.Show("Row deleted successfully.");
                }
            }
        }



        public static CasesUserControl Instance()
        {
            return _CasesUserControl ?? ( new CasesUserControl());
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT ID,Name,gender,description FROM Cases WHERE Name LIKE '%" + searchtextBox.Text + "%'; ";

            casesTable = new DataTable(); // Initialize the DataTable here
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;
            dataGridView1.Columns["ID"].Visible = false;
            
            connection.Close();
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string gender = row.Cells[2].Value.ToString();
            string desc = row.Cells[3].Value.ToString();
            // Do something with the row number, such as display it in a message box


            editeCases editeCases = new editeCases(id, name, gender, desc);

            editeCases.ShowDialog();

            showTable();

            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCases addCases = new AddCases();

            addCases.ShowDialog();

            showTable();

        }

        private void showTable()
        {

            string query = "SELECT ID,Name,gender,description  FROM Cases;";
            casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;

            dataGridView1.Columns["ID"].Visible = false;


            connection.Close();
        }
    }
}
