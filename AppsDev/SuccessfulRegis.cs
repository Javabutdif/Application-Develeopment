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
    public partial class SuccessfulRegis : UserControl
    {
        public SuccessfulRegis()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void SuccessfulRegis_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.displaySuccess.BackColor = color.lighterDark();
            this.continueBut.BackColor = color.lighter();
        }
        public int counter = 0;
        public void continueBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            counter++;
           
        }
    }
}
