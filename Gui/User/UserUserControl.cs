using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace collageProject.Gui.User
{
    public partial class UserUserControl : UserControl
    {
        private static UserUserControl _UserUserControl;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        public UserUserControl()
        {
            InitializeComponent();
            ShowTable();


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "حذف";
            deleteButton.UseColumnTextForButtonValue = true;

            // Set the button cell template to a new instance of DataGridViewButtonCell

            // Add the button column to the DataGridView
            UserdataGridView.Columns.Add(deleteButton);

            // Handle the CellContentClick event to detect button clicks
            UserdataGridView.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Delete" button
            if (UserdataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Get the ID of the row to delete
                int id = (int)UserdataGridView.Rows[e.RowIndex].Cells["ID"].Value;
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?" , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   
                    // Delete the row from the database
                    string query = "DELETE FROM users WHERE id = @idValue;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idValue", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    // Remove the row from the DataGridView
                    UserdataGridView.Rows.RemoveAt(e.RowIndex);
                    
                    // Show a message box to indicate that the row has been deleted
                    MessageBox.Show("Row deleted successfully.");

                }
            }
        }



        private void ShowTable()
        {
            string query = $"SELECT * FROM [DBCollageproject].[dbo].[Users] ;";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            UserdataGridView.DataSource= dataTable;
            UserdataGridView.Columns["ID"].Visible= false;

        }

        public static UserUserControl Instance()
        {
            return _UserUserControl ?? (new UserUserControl());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm     = new AddUserForm();

            addUserForm.ShowDialog();
            ShowTable();
        }

        private void UserdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowNumber = e.RowIndex;
            DataGridViewRow row = UserdataGridView.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[1].Value.ToString();
            string Name = row.Cells[2].Value.ToString();
            string UserName = row.Cells[3].Value.ToString();
            string Password = row.Cells[4].Value.ToString();
            string admin = row.Cells[5].Value.ToString();
            EditUserForm edit= new EditUserForm(id,Name,UserName,Password,admin);  

            edit.ShowDialog();
            ShowTable();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [DBCollageproject].[dbo].[Users] where Name like '%{searchtextBox.Text}%';";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            UserdataGridView.DataSource = dataTable;
            UserdataGridView.Columns["ID"].Visible = false;
        }
    }
}
