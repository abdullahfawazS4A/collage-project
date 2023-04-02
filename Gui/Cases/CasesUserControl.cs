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
        public CasesUserControl()
        {
            InitializeComponent();
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Cases;";

            casesTable = new DataTable(); // Initialize the DataTable here
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);

            dataGridView1.DataSource = casesTable;
            // Set the DataTable object as the data source for the DataGridView control
            dataGridView1.DataSource = casesTable;
            connection.Close();
        }

        public static CasesUserControl Instance()
        {
            return _CasesUserControl ?? (_CasesUserControl = new CasesUserControl());
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Cases WHERE Name LIKE '%" + searchtextBox.Text + "%'; ";

            casesTable = new DataTable(); // Initialize the DataTable here
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);

            dataGridView1.DataSource = casesTable;
            // Set the DataTable object as the data source for the DataGridView control
            dataGridView1.DataSource = casesTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ; // Set the DataTable as the data source for the DataGridView

        }
    }
}
