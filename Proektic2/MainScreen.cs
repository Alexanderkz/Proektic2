using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proektic2
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.Location);
            this.Refresh();
        }
    }
}



     
     
    
