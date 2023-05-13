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
         
            MyBaseForm data = new MyBaseForm();

            this.lastNameDisplay.Text = data.getL + ",";
            this.firstNameDisplay.Text = data.getF;

            this.regionNum.Text = data.getR;
            this.provinceData.Text = data.getP;
            this.cityData.Text = data.getC;
            this.barangayData.Text = data.getB;

        }

        private void refCode_VisibleChanged(object sender, EventArgs e)
        {
            Regis reg = new Regis();

            this.infoD.Text = reg.getInfo;
            this.codeR.Text = reg.Reference;
        }
    }

}
