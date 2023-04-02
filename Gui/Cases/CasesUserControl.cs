using collageProject.Gui.home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.Cases
{
    public partial class CasesUserControl : UserControl
    {
        private static CasesUserControl _CasesUserControl;
        public CasesUserControl()
        {
            InitializeComponent();
        }

        public static CasesUserControl Instance()
        {
            return _CasesUserControl ?? (new CasesUserControl());

        }
    }
}
