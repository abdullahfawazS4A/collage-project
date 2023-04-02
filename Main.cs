using collageProject.Code;
using System;

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
            pageManager.LoadPage(Gui.home.UserControlHome.Instance()); pageManager.LoadPage(Gui.Cases.CasesUserControl.Instance());

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
