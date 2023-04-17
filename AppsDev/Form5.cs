using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Hover color = new Hover();

        private void Form5_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = color.darker();
            this.BackColor = color.lighter();
            this.panel2.BackColor = color.lightDark();

        }
        private void dashH(object sender, EventArgs e)
        {
            dashB.BackColor = color.lighter();

        }
        private void dashL(object sender, EventArgs e)
        {
            dashB.BackColor = color.darker();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to log out? ","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(d == DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }
}
