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
    public partial class AddapplicantsForm : Form
    {
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        string id_applicant;
        public AddapplicantsForm()
        {
            InitializeComponent();
            showTable();
        }

        private void showTable() {

            string query = "select applicants.id,first_name+' '+second_name+' '+last_name as N'الاسم',applicants.gender N'الجنس',birthday  N'تاريخ الميلاد',cases.Name as N'اسم الحالة' FROM applicants INNER JOIN cases ON applicants.id_case = cases.id WHERE added =0;";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(this.casesTable);
            applicantsTable.DataSource = this.casesTable;

            // don't show the id 
           applicantsTable.Columns["Id"].Visible = false;

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = "select applicants.id as id,first_name+' '+second_name+' '+last_name as N'الاسم',applicants.gender N'الجنس',birthday  N'تاريخ الميلاد',cases.Name as N'اسم الحالة' FROM applicants INNER JOIN cases ON applicants.id_case = cases.id WHERE added =0 and " +
                "first_name LIKE '%"+ searchtextBox.Text+ "%' or last_name LIKE '%" + searchtextBox.Text + "%'or second_name LIKE '%"+searchtextBox.Text+"%';";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();             
            adapter.Fill(this.casesTable);
            applicantsTable.DataSource = this.casesTable;

            // don't show the id 
            applicantsTable.Columns["id"].Visible = false;
        }

        private void applicantsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = e.RowIndex;
            DataGridViewRow row = applicantsTable.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[0].Value.ToString();
            AddToacceptedForm addToacceptedForm= new AddToacceptedForm(id);

            addToacceptedForm.ShowDialog();
           
            
        }
    }

    
}
