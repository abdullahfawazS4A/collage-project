using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collageProject.Gui.home
{
    public partial class UserControlHome : UserControl
    {
        private static UserControlHome _HomeUserControl1;
        public UserControlHome()
        {
            InitializeComponent();
        }
        public static UserControlHome Instance()
        {
            return _HomeUserControl1 ?? (new UserControlHome());

        }

        
    }
}
