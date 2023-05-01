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
    public partial class SonsUserControl : UserControl
    {
        private static SonsUserControl _SonsUserControl;

        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public SonsUserControl()
        {
            InitializeComponent();
            ShowTable();
        }

        private void ShowTable()
        {
            string query = "SELECT  accepted.id,   [first_name]+' '+[second_name]+' '+[last_name] as N'الاسم' , ap.gender as N'الجنس',[birthday] as N'المواليد',[phone_number] as N'الرقم',cases.Name N'اسم الحالة' FROM applicants as ap inner join cases on id_case = cases.ID inner join accepted on ap.id = accepted.id_applicant  where added=1 ;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;
            dataGridView1.Columns["id"].Visible = false;

        }

        public static SonsUserControl Instance()
        {

            return _SonsUserControl ?? (new SonsUserControl());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowNumber];

            // Access the text of each cell in the row using the Cells property
            string id = row.Cells[0].Value.ToString();
            ShowSonsForm showSonsForm   = new ShowSonsForm( id);
            this.ParentForm.Visible = false;
            showSonsForm.ShowDialog();
            this.ParentForm.Visible = true;
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT  accepted.id,   [first_name]+' '+[second_name]+' '+[last_name] as N'الاسم' , ap.gender as N'الجنس',[birthday] as N'المواليد',[phone_number] as N'الرقم',cases.Name N'اسم الحالة' " +
                $"FROM applicants as ap inner join cases on id_case = cases.ID inner join accepted on ap.id = accepted.id_applicant  where added=1 and  [first_name]+' '+[second_name]+' '+[last_name] like '%{searchtextBox.Text}%'  ;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            dataGridView1.DataSource = casesTable;
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
