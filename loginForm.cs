using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject
{

    
    public partial class loginForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        public loginForm()
        {
            InitializeComponent();
            
          
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = UserNametextBox.Text;
            string password = PassWordtextBox.Text;

            string query = $"SELECT [ID], [Name], [UserName], [Password] FROM [DBCollageproject].[dbo].[Users] WHERE UserName = '{username}'";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                // The username and/or password fields are empty, so show an error message
                MessageBox.Show("Please enter a username and password.");
            }
            else if (dataTable.Rows.Count == 0)
            {
                // The entered username does not exist in the database, so show an error message
                MessageBox.Show("اسم المستخدم خطأ ...");
            }
            else if (dataTable.Rows[0]["Password"].ToString() != password)
            {
                // The entered password is incorrect, so show an error message
                MessageBox.Show("كلمة السر خطأ حاول مجددا ...");
            }
            else
            {
                // The username and password are correct, so show the main form
                Main main = new Main(this, dataTable.Rows[0]["ID"].ToString());
                this.Hide();
                main.Show();
            }
        }


    }
}
