using collageProject.Code;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace collageProject
{
    public partial class Main : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        string connectionString = "Server=ABD;Database=DBCollageproject;Trusted_Connection=True;";
        private loginForm login;
        private readonly PageManager pageManager;
        string Id_user;
        public Main(loginForm login,string Id_user)
        {
          
            InitializeComponent();
         
            pageManager = new PageManager(this);
              this.Id_user = Id_user;
         CheckUSerAdmin();
            //load home page
            this.login=login;

        }
        private void CheckUSerAdmin()
        {
            string query = $"SELECT Validity FROM [DBCollageproject].[dbo].[Users] WHERE ID = {this.Id_user}";

            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows[0]["Validity"].ToString()=="False")
            Userbutton.Hide();
            
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.home.UserControlHome.Instance());
        }

      

        private void Casesbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.Cases.CasesUserControl.Instance());
            
        }

        private void Acceptbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.accapted.AcceptedUserControl.Instance());
        }

        private void Applicantbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.applicants.ApplicantUserControl.Instance());
        }

        private void Statisticsbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.Statistics.Statistics.Instance());
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Close();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
         pageManager.LoadPage(Gui.User.UserUserControl.Instance());
        }

        private void Sonsbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.sons.SonsUserControl.Instance());
        }
    }
}
