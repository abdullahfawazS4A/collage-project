using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace collageProject.Gui.User
{
    public partial class AddUserForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        private SqlCommand comman;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        public AddUserForm()
        {
            InitializeComponent();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (NametextBox1.Text == "")
            {

                MessageBox.Show("اسم فارغ ...");

            }
            else if (PasswordtextBox3.Text == "")
            {
                MessageBox.Show("كلمة السر فارغه ...");
            }
            else if (UserNametextBox2.Text == "")
            {
                MessageBox.Show("اسم المستخدم فارغ ...");

            }
            else
            {
                string query = $"SELECT  [UserName] FROM [DBCollageproject].[dbo].[Users] where UserName = '{UserNametextBox2.Text}';";
                DataTable dt =new DataTable();
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(query, connection);
                connection.Open();
                adapter.Fill(dt);
                connection.Close();
                if (dt.Rows.Count == 0)
                {



                    string admin;
                    if (ValiditycheckBox1.Checked == true)
                    {
                        admin = "1";
                    }
                    else
                    {
                        admin = "0";
                    }
                    string query2 = $"INSERT INTO Users (Name, UserName, Password,Validity)" +
                        $" VALUES ('{NametextBox1.Text}', '{UserNametextBox2.Text}', '{PasswordtextBox3.Text}',{admin});";

                    connection = new SqlConnection(connectionString);
                    comman = new SqlCommand(query2, connection);
                    connection.Open();
                    comman.ExecuteNonQuery();
                    connection.Close();

                    NametextBox1.Text = "";
                    UserNametextBox2.Text = "";
                    PasswordtextBox3.Text = "";
                    ValiditycheckBox1.Checked = false;

                }
                else
                {

                    MessageBox.Show("اسم المستخدم موجود ...");
                }

            }
        }
    }
}
