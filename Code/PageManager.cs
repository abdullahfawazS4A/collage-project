using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace collageProject.Code
{
    internal class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }

        public void LoadPage(UserControl PageUserControl)
        {   
            // load old page 
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();

            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);
                oldPage.Dispose();
            }

            //load new page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
