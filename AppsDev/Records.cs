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
        }
    }
}
