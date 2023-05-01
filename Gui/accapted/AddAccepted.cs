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
    public partial class AddAccepted : Form
    {
        string id_case ="118";
        string oldfullname;
        string id;
        string id_applicant;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private DataTable casesTable;
        private DataTable casesTable2;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public AddAccepted( string id,string id_applicant)
        {
            this.id = id;
            this.id_applicant= id_applicant;
            InitializeComponent();
            fillcomvboxCases();
            fillThetextbox();
            this.oldfullname = nametextBox.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void numberphonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, mark the event as handled to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void sonstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, mark the event as handled to prevent the character from being entered
                e.Handled = true;
            }
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
                            CasescomboBox.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private void fillThetextbox()
        {
            string query = "SELECT ac.* ,a.* FROM applicants a INNER JOIN accepted ac ON a.id = ac.id_applicant where ac.id ="+this.id+";";
            this.casesTable = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(this.casesTable);

            foreach (DataRow row in casesTable.Rows)
            {
                // Get the value of the "ID" column for the current row
                

                // Get the value of the "Name" column for the current row
                string name = (string)row["first_name"]+" "+ (string)row["second_name"]+" "+ (string)row["last_name"];
                string mothers_name = (string)row["mothers_name"];
                string marital_statusr = (string)row["marital_statusr"];
                string gender = (string)row["gender"];
                string birthday = (string)row["birthday"].ToString();
                string number_of_sons = (string)row["number_of_sons"].ToString();
                string department = (string)row["department"];
                string records_newspaper_number = (string)row["records_newspaper_number"];
                string release_date = (string)row["release_date"].ToString();
                string educational_attainment = (string)row["educational_attainment"];
                string supply_center_number = (string)row["supply_center_number"];
                string ration_card = (string)row["ration_card"];
                string place_of_birth = (string)row["place_of_birth"];
                string closest_function_point = (string)row["closest_function_point"];
                string district_center = (string)row["district_center"];
                string district = (string)row["district"];
                string log = (string)row["log"];
                string identitynumber = (string)row["identitynumber"];
                string phone_number = (string)row["phone_number"];

                string id_case = (string)row["id_case"].ToString();


                nametextBox.Text = name;
                mothers_nametextBox.Text = mothers_name;

              
                marital_statusrcomboBox1.Text = marital_statusr;
                gendercomboBox2.Text= gender;
                birthdaydateTimePicker2.Text = birthday;
                release_datedateTimePicker.Text = release_date;
                string namecases = getcaseid(id_case);
                CasescomboBox.Text=namecases;
                departmenttextBox.Text= department;
                logtextBox.Text = log;
                records_newspaper_numbertextBox.Text = records_newspaper_number;
                identitynumbertextBox.Text= identitynumber;
                place_of_birthtextBox.Text = place_of_birth;


                sonstextBox.Text = number_of_sons;
                educational_attainmenttextBox.Text = educational_attainment;
                ration_cardtextBox.Text = ration_card;
                numberphonetextBox.Text = phone_number;
                supply_center_numbertextBox.Text = supply_center_number;

               

                districttextBox.Text = district;
                district_centertextBox.Text=district_center;
                closest_function_pointtextBox.Text = closest_function_point;
               
                // Do something with the values
            }

        }


        private string getcaseid(string caseid)
        {   if (caseid ==" " || caseid == ""||caseid==null)
            {

                return caseid;
            }
            string namecase;
            string query = "select name from cases where id = "+caseid+";";
            this.casesTable2 = new DataTable();


            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            connection.Open();
            adapter.Fill(this.casesTable2);
            foreach (DataRow row in casesTable2.Rows)
            {
                 namecase = row["name"].ToString();
                connection.Close();
                return namecase;
               
            }
            return null;
            
            }

        private void save_button_Click(object sender, EventArgs e)
        {
          updateData();
        }


        private void updateData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string first_name ;
            string second_name ;
            string last_name ;
            
                string fullName = nametextBox.Text.ToString();

                string[] fullNameArray = fullName.Split(' ');

                 first_name = fullNameArray[0];
                 second_name = fullNameArray[1];
                 last_name = fullNameArray[2];
              
                string mothers_name = mothers_nametextBox.Text.ToString();
                string gender = gendercomboBox2.Text.ToString();
                string marital_statusr = marital_statusrcomboBox1.Text.ToString();
            string birthday = birthdaydateTimePicker2.Value.ToString("yyyy-MM-dd");

            // create a SqlCommand object with the SQL comment
            string sql = $"UPDATE [dbo].[applicants] SET first_name = N'{first_name}', second_name = N'{second_name}', last_name = N'{last_name}', mothers_name = N'{mothers_name}', gender = N'{gender}', marital_statusr = N'{marital_statusr}', birthday = N'{birthdaydateTimePicker2.Value.Date}' , number_of_sons = N'{sonstextBox.Text.ToString()}'" +
                $", department = N'{departmenttextBox.Text.ToString()}', log = N'{logtextBox.Text}' ,records_newspaper_number = '{records_newspaper_numbertextBox.Text}' ,identitynumber = '{identitynumbertextBox.Text}'" +
                $", release_date = N'{release_datedateTimePicker.Value.Date}', educational_attainment = N'{educational_attainmenttextBox.Text}'  , supply_center_number = N'{supply_center_numbertextBox.Text}'  " +
                $", ration_card = N'{ration_cardtextBox.Text}' , phone_number = N'{numberphonetextBox.Text}' " +
                $", closest_function_point = N'{closest_function_pointtextBox.Text}', district_center = N'{district_centertextBox.Text}', district = N'{districttextBox.Text}', id_case = N'{getIdCase(CasescomboBox.Text.ToString())}'" +
                $" WHERE id = {this.id_applicant};"; ;
            SqlCommand command = new SqlCommand(sql, connection);

            // open the connection and execute the command
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void nametextBox_Leave(object sender, EventArgs e)
        { string fullName = nametextBox.Text.ToString();
           
                string[] fullNameArray = fullName.Split(' ');
            try
            {
                string first_name = fullNameArray[0];
                string second_name = fullNameArray[1];
                string last_name = fullNameArray[2];
                nametextBox.BackColor = Color.White;
               
            }
            catch(Exception ex) {


                nametextBox.BackColor = Color.Red;
                MessageBox.Show("يجب ان يحتوي الاسم على ثلاث اسماء بينهم فراغين");
                nametextBox.Text = this.oldfullname;
            
            }

                
            
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
                id_case = row["id"].ToString();
               return id_case;

            }
            return "";
        }

        private void AddAccepted_FormClosing(object sender, FormClosingEventArgs e)
        {
        
           
        }

        
    }
}
