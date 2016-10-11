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

            int FORM_WIDTH_SIZE = 500;
            int FORM_HEIGHT_SIZE = 400 - 24;
            CsvView csvView = new CsvView()
            {
                Width = FORM_WIDTH_SIZE,
                Height = FORM_HEIGHT_SIZE,
                GridLines = true,
                View = View.Details,
                Dock = DockStyle.Bottom,
            };
            this.Controls.Add(csvView);
            csvView.Items[1].Focused = true;
            csvView.Select();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
