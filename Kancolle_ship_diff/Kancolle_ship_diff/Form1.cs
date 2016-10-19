using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSortableListViewLib;

namespace Kancolle_ship_diff
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            // csvView.Items[1].Focused = true;
            // csvView.Select();
        }

        private void csvView_SelectedIndexChanged(object sender, EventArgs e)
        {

            csvView.Sort();
        }

    }
}
