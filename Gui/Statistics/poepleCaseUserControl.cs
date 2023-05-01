using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;

namespace collageProject.Gui.Statistics
{
    public partial class poepleCaseUserControl : UserControl
    {
        private static CasesUserControl _CasesUserControl;
        private DataTable casesTable;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        string namecase;

        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        public poepleCaseUserControl(string namecase)
        {
            InitializeComponent();
            this.namecase= namecase;
            showtable();
            
        }


        
        

        private void showtable()
        {

            string id = getIdCase(this.namecase);
           
            string query = $"select first_name+' '+second_name+' '+last_name as N'الاسم',applicants.phone_number as N'رقم الهاتف',applicants.gender as N'الجنس',applicants.educational_attainment as N'التحصيل الدراسي',applicants.marital_statusr as N'الحالة الاجتماعية' from accepted inner join applicants on accepted.id_applicant = applicants.id where id_case={id};";
            casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(casesTable);
            poeplecasedataGridView.DataSource = casesTable;

            connection.Close();
        }


        private string getIdCase(string selectedItem)
        {


            string query = $"select id from cases where Name =N'{selectedItem}';";
            DataTable dt = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string id_case = row["id"].ToString();
                connection.Close();
                return id_case;

            }
            return "0";
        }

        private void saveexcelbutton1_Click(object sender, EventArgs e)
        {
            // Convert the DataTable to an Excel file
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            // Add columns to worksheet manually
            int columnCount = casesTable.Columns.Count;
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Cells[1, i + 1].Value = casesTable.Columns[i].ColumnName;
            }

            // Add data rows to worksheet
            int rowCount = casesTable.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = casesTable.Rows[i][j];
                }
            }

            FileInfo excelFile = new FileInfo(@"C:\Users\abdullah\OneDrive\Desktop\file2222.xlsx");
            excelPackage.SaveAs(excelFile);

            MessageBox.Show("Excel file saved successfully!");
        }

        private void poepleCaseUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
