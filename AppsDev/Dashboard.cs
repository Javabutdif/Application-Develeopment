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
            this.BackColor = color.lighter();


        }
      
       public void setData(string ln, string fn, string md, string r, string p, string c, string b)
        {
            this.lastNameDisplay.Text = ln;
            this.firstNameDisplay.Text = fn;
            this.middleNameDisplay.Text = md;
            this.regionDisplay.Text = r;
            this.provinceData.Text = p;
            this.cityData.Text = c;
            this.barangayData.Text = b;

        }
    }
    
    }
