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
            this.listBox2.BackColor = color.lighterDark();
            this.panel1.BackColor = color.lighterDark();
            this.panel1.ForeColor = Color.White;
            this.clearAll.BackColor = color.lighterDark();
            this.clearAll.ForeColor = Color.White;
        }
        Civil c = new Civil();

        private string path = @"C:\Barangay Registration\Database\Citizen.txt";
        private void listView1_VisibleChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            c.setData();
            foreach (Civil cd in c.getData())
            {
                this.listBox1.Items.Add(cd.Lastname + " " + cd.Firstname + " " + cd.MIDdlename);
                this.listBox2.Items.Add(cd.reference);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to Clear All the Database? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(path))
                {
                    write.Write("");
                }
                this.listBox1.Items.Clear();
            }

        }
    }
}
