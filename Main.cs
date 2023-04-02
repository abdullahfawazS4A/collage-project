using collageProject.Code;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace collageProject
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);

            //load home page

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.home.UserControlHome.Instance());
        }

      

        private void Casesbutton_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.Cases.CasesUserControl.Instance());
            
        }
    }
}
