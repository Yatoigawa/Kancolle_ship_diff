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

namespace Kancolle_ship_diff
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CsvView csvView = new CsvView()
            {
                GridLines = true,
                View = View.Details,
                Dock = DockStyle.Fill,
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
