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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.panel3.BackColor = color.lighter();
            this.panel12.BackColor = color.lightDark();
            this.panel1.BackColor = color.lightDark();
            this.panel4.BackColor = color.lightDark();
            this.panel5.BackColor = color.lighterDark();
        }
    }
}
