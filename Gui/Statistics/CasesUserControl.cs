using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.Statistics
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
            showtable();
        }

        private void showtable()
        {


            string query = "select c.Name as N'اسم الحالة',count(*) as N'عدد الاشخاص ' " +
                "from applicants as a inner join cases as c on a.id_case = c.id group by c.Name";
            casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);
            casedataGridView.DataSource = casesTable;

            connection.Close();
        }

        private void casedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = e.RowIndex;
            DataGridViewRow row = casedataGridView.Rows[rowNumber];

            string name = row.Cells[0].Value.ToString();
            poepleCaseUserControl uc2 = new poepleCaseUserControl(name);
            uc2.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);
        }
    }
}
