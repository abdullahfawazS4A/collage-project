using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;

namespace collageProject.Gui.applicants
{
    public partial class ApplicantUserControl : UserControl
    {     string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;
        private DataTable casesTable2;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private static ApplicantUserControl _ApplicantUserControl;
        DataTable dataTable= new DataTable();
        public ApplicantUserControl()
        {
            InitializeComponent();
        }

        public static ApplicantUserControl Instance()
        {
            return _ApplicantUserControl ?? (new ApplicantUserControl());
        }

        private string getIdCase(string selectedItem)
        {


            string query = $"select id from cases where Name =N'{selectedItem}'";
            DataTable dt = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                 
                return row["id"].ToString(); ;

            }
            return "NULL";
        }

        private void showbutton_Click_1(object sender, EventArgs e)
        {

            // Show the open file dialog
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select an Excel file";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Open the file stream using the selected file path
            using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                // Register the ISO-8859-1 encoding provider
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                // Create an ExcelDataReader object and pass in the FileStream
                using (var reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration()
                {
                    FallbackEncoding = Encoding.GetEncoding("ISO-8859-1")
                }))
                {
                    // Read the data from the Excel file into a DataSet
                    var dataSet = reader.AsDataSet();

                    // Get the first DataTable from the DataSet
                     this.dataTable = dataSet.Tables[0];

                    // Set the column names of the DataTable to match the column names in the Excel file
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        dataTable.Columns[i].ColumnName = dataSet.Tables[0].Rows[0][i].ToString();
                    }

                    // Remove the first row (the row with the column names)
                    dataTable.Rows.RemoveAt(0);

                    // Do something with the DataTable (e.g., bind it to a DataGridView)
                    tableAccepted.DataSource = dataTable;
                  
                }


            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                SqlConnection connection = new SqlConnection(connectionString);

                int rowCount = dataTable.Rows.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    // create a SqlCommand object with the SQL comment
                    string sql = $"INSERT INTO [dbo].[applicants] ([id],[first_name],[second_name]  ,[last_name],[number_of_sons],[department],[records_newspaper_number] ,[release_date],[gender]" +
                            $",[birthday]    ,[mothers_name]   ,[educational_attainment]  ,[supply_center_number]     ,[ration_card],[place_of_birth]\r\n      ,[phone_number]\r\n  " +
                            $"    ,[closest_function_point]\r\n      ,[district_center]\r\n      ,[district]" +
                            $",[log]\r\n      ,[identitynumber]\r\n      ,[marital_statusr],[id_case],[added])" +
                        $"   VALUES ({GetNewId()},'{row["first_name"]}','{row["second_name"]}','{row["last_name"]}','{row["number_of_sons"]}','{row["department"]}','{row["records_newspaper_number"]}','{row["release_date"]}','{row["gender"]}'" +
                        $",'{row["birthday"]}','{row["mothers_name"]}','{row["educational_attainment"]}','{row["supply_center_number"]}','{row["ration_card"]}'" +
                        $",'{row["place_of_birth"]}','{row["phone_number"]}','{row["closest_function_point"]}','{row["district_center"]}','{row["district"]}'" +
                        $",'{row["log"]}','{row["identitynumber"]}','{row["marital_statusr"]}',{getIdCase(row["case"].ToString())},0)"; ;
                    SqlCommand command = new SqlCommand(sql, connection);

                    // open the connection and execute the command
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                } 
                dataTable.Clear();
            MessageBox.Show("تم الاضافة");
            }
            else
            {
                MessageBox.Show("الجدول فارغ");
            }
        }

        private int GetNewId()
        {
            int newId = 0;
            string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
            string query = "SELECT MAX(ID) FROM applicants;"; // Get the maximum existing ID in the table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    newId = Convert.ToInt32(result) + 1; // Increment the maximum ID by 1 to get a new ID
                }
                connection.Close();
            }
            return newId;
        }
    }
}
