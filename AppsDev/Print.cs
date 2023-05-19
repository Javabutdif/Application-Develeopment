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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void Print_Load(object sender, EventArgs e)
        {

            this.BackColor = color.lighter();
            this.button1.BackColor = color.lighter();
            this.label2.Visible = false;
            this.button1.Visible = false;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
