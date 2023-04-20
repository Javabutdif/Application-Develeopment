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
    public partial class Registration : MyBaseForm
    {
        public Registration()
        {
            InitializeComponent();
        }
        Hover color = new Hover();  
        private void Registration_Load(object sender, EventArgs e)
        {
            this.button1.BackColor = color.lighter();
        }

     
    }
}
