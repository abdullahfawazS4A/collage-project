using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.Statistics
{
    public partial class FilterUserControl : UserControl
    {
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;
       
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        string frombirthday;
        string tobirthday;
        string allbirthday;
        string Case;
        string AllCase;
        string Status;
        string AllStatus;
        public FilterUserControl()
        {
            InitializeComponent();
            fillcomvboxCases();
            ShowTable();

            birthdaycheckBox.Checked = false;
            CasecheckBox2.Checked = false;
            StatuscheckBox3.Checked = false;

            FromdateTimePicker1.Enabled = false;
            TodateTimePicker2.Enabled = false;
            marital_statusrcomboBox2.Enabled
                = false;
            casecomboBox.Enabled = false;

            this.frombirthday = "";
            this.tobirthday = "";
            this.allbirthday = "";
            this.Case = "";
            this.AllCase = "";
            this.Status = "";
            this.AllStatus = "";
        }

        private void ShowTable()
        {
            string query = "SELECT     [first_name]+' '+[second_name]+' '+[last_name] as N'الاسم' , ap.gender as N'الجنس',[birthday] as N'المواليد',[phone_number] as N'الرقم',cases.Name N'اسم الحالة' FROM applicants as ap inner join cases on id_case = cases.ID where added=1 ;\r\n";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            FilterdataGridView.DataSource = casesTable;


        }
        private void fillcomvboxCases()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define a SQL SELECT statement to retrieve data from the table
                string query = "SELECT [ID] ,[Gender] ,[Name] ,[description] FROM [DBCollageproject].[dbo].[cases]";

                // Create a new SqlCommand object to execute the SQL statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the database connection
                    connection.Open();

                    // Execute the SQL statement and retrieve the data using a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the data and add each item to the ComboBox control
                        while (reader.Read())
                        {
                            casecomboBox.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }

        private void birthdaycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(birthdaycheckBox.Checked)
            {
                TodateTimePicker2.Enabled=true; 
                FromdateTimePicker1.Enabled =true;

            }
            else
            {
                TodateTimePicker2.Enabled = false;
                FromdateTimePicker1.Enabled = false;
                this.allbirthday = "";
            }
        }

        private void CasecheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CasecheckBox2.Checked)
            {
                casecomboBox.Enabled=true;

            }
            else
            {
                casecomboBox.Enabled = false;
                this.AllCase = "";
            }
        }

        private void StatuscheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(StatuscheckBox3.Checked)
            {

                marital_statusrcomboBox2.Enabled=true;
            }
            else
            {
                marital_statusrcomboBox2.Enabled = false;
                this.AllStatus = "";
            }
        }

        private void Filterbutton1_Click(object sender, EventArgs e)
        {

            if (birthdaycheckBox.Checked)
            {

                this.frombirthday = $"{FromdateTimePicker1.Value.Date}";
                this.tobirthday = $"{TodateTimePicker2.Value.Date}";

                this.allbirthday = $"and birthday >= '{this.frombirthday}' and birthday <= '{this.tobirthday}' ";

            }
            if (CasecheckBox2.Checked)
            {
                this.Case=casecomboBox.Text;
                this.AllCase = $" and cases.Name =N'{this.Case}'";
            }

            if (StatuscheckBox3.Checked)
            {
                this.Status = marital_statusrcomboBox2.Text;
                this.AllStatus = $"and ap.marital_statusr=N'{this.Status}'";
            }
            string query = $"SELECT     [first_name]+' '+[second_name]+' '+[last_name] as N'الاسم' , ap.marital_statusr as N'الحالة الاجتماعية', ap.gender as N'الجنس',[birthday] as N'المواليد',[phone_number] as N'الرقم',cases.Name N'اسم الحالة' FROM applicants as ap inner join cases on id_case = cases.ID " +
                $"where added=1 {this.allbirthday} {this.AllCase} {this.AllStatus} ;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            this.casesTable = new DataTable();
            adapter.Fill(casesTable);
            FilterdataGridView.DataSource = casesTable;
        }

        private void Savebutton_Click(object sender, EventArgs e)
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

            FileInfo excelFile = new FileInfo(@"C:\Users\abdullah\OneDrive\Desktop\filbbbbbbb.xlsx");
            excelPackage.SaveAs(excelFile);

            MessageBox.Show("Excel file saved successfully!");
        }
    }
}
