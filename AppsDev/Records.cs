using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
    public partial class Records : UserControl
    {
        public Records()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void Records_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.listBox1.BackColor = color.lighterDark();
            this.panel1.BackColor = color.lighterDark();
            this.panel1.ForeColor = Color.White;
        }
        Civil c = new Civil();

        private string path = @"C:\Barangay Registration\Database\Citizen.txt";
        private void listView1_VisibleChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            c.setData();
            foreach (Civil cd in c.getData())
            {
                this.listBox1.Items.Add(" " + cd.Lastname + " " + cd.Firstname + " " + cd.MIDdlename + "                   " + cd.reference + "\n");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
