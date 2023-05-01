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
    public partial class ShowSonsForm : Form
    {
        string Id;
        private static SonsUserControl _SonsUserControl;

        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public ShowSonsForm(string Id)
        {
            InitializeComponent();
          
            this.Id = Id;
            ShowTable();
            // add delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "حذف";
            deleteButton.UseColumnTextForButtonValue = true;

            // Set the button cell template to a new instance of DataGridViewButtonCell

            // Add the button column to the DataGridView
            dataGridView1.Columns.Add(deleteButton);

            // Handle the CellContentClick event to detect button clicks
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Delete" button
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Get the ID of the row to delete
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
              
                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?" , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                  
                    // Delete the row from the database
                    string query = "DELETE FROM sons WHERE id = @idValue;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idValue", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    // Show a message box to indicate that the row has been deleted
                    MessageBox.Show("Row deleted successfully.");

                }
            }
        }


        private void ShowTable()
        {


            string query = "SELECT   s.id,[full_name] as N'الاسم ',[gender] as N'الجنس',[birthday] as N'المواليد',[mothers_name]as N'اسم الام',[identification_number]as N'التحصيل الدراسي',fa.name as N'صلة القرابة',[id_accepted]" +
                $" FROM sons as s inner join family_head as fa on s.head_family_id = fa.id  where id_accepted ={this.Id}";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["id_accepted"].Visible = false;

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT   s.id,[full_name] as N'الاسم ',[gender] as N'الجنس',[birthday] as N'المواليد',[mothers_name]as N'اسم الام',[identification_number]as N'التحصيل الدراسي',fa.name as N'صلة القرابة',[id_accepted]" +
                $" FROM sons as s inner join family_head as fa on s.head_family_id = fa.id  where id_accepted ={this.Id} and full_name like N'%{searchtextBox.Text}%' ";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["id_accepted"].Visible = false;

        } 

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSonsForm addSonsForm = new AddSonsForm(this.Id);
            addSonsForm.ShowDialog();

            ShowTable();    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowNumber = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[1].Value.ToString();

            EditeForm editeForm = new EditeForm(id);
          
            editeForm.ShowDialog();
            ShowTable();


        }
    }
}
