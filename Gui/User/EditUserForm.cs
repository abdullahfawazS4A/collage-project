using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.User
{
    public partial class EditUserForm : Form
    {

        string id_user;
              private SqlConnection connection;
        private SqlCommand adapter;
        private SqlDataAdapter adapter2;
        private SqlCommand comman;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        string User_Namecheck;
        public EditUserForm(string id_user,string Name ,string UserName ,string Password,string admin)
        {
            InitializeComponent();

            this.id_user = id_user;
            
            NametextBox1.Text = Name;
            UserNametextBox2.Text = UserName;
            PasswordtextBox3.Text = Password;
            this.User_Namecheck = UserNametextBox2.Text;
            if (admin=="True")
            ValiditycheckBox1.Checked = true;
            else
                ValiditycheckBox1.Checked = false;
        }

        private void FillText()


        {
            string query = $"SELECT  [UserName] FROM [DBCollageproject].[dbo].[Users] where UserName = '{UserNametextBox2.Text}';";
            DataTable dt = new DataTable();
            connection = new SqlConnection(connectionString);
            adapter2 = new SqlDataAdapter(query, connection);
            connection.Open();
            adapter2.Fill(dt);
            connection.Close();
            if (dt.Rows.Count == 0 || this.User_Namecheck==UserNametextBox2.Text)
            {


                string Validity;
                if (ValiditycheckBox1.Checked)
                    Validity = "1";
                else
                    Validity = "0";
                string query2 = $"UPDATE Users SET Name = '{NametextBox1.Text}',UserName ='{UserNametextBox2.Text}' ,password ='{PasswordtextBox3.Text}',Validity={Validity} where ID={this.id_user};";
                connection = new SqlConnection(connectionString);
                adapter = new SqlCommand(query2, connection);
                connection.Open();
                adapter.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            else
            {

                MessageBox.Show("اسم المستخدم موجود ...");
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            FillText();
        }
    }
}
