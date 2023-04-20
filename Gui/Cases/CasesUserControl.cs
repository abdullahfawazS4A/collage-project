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
            


            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

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

            Console.WriteLine(id, name, gender, desc);
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
            dataGridView1.Columns["Name"].HeaderText = "اسم الحالة";
            dataGridView1.Columns["gender"].HeaderText = "الجنس";
            dataGridView1.Columns["description"].HeaderText = "تفاصيل الحالة";
            connection.Close();
        }
    }
}





