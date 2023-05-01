using collageProject.Gui.home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.Statistics
{
    public partial class Statistics : UserControl
    {
        private static Statistics _Statistics;
        public Statistics()
        {
            InitializeComponent();
        }

        public static Statistics Instance()
        {
            return _Statistics?? (new Statistics());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CasesUserControl uc2 = new CasesUserControl();
            uc2.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterUserControl uc2 = new FilterUserControl();
            uc2.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc2);
        }
    }
}
