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
    public partial class Form5 : MyBaseForm
    {
        string value = "";
        Hover color = new Hover();
        public Form5()
        {
            InitializeComponent();

        }
        public Form5(string data)
        {
            this.value = data;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.panel3.BackColor = color.lighter();
            this.panel12.BackColor = color.lightDark();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
