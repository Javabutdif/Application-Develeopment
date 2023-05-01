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
      
        public string setLast
        {
            set
            {
                lastNameDisplay.Text = value;
 
            }
        }
        public string setFirst
        {
            set
            {
                firstNameDisplay.Text = value;
            }



        }
        public string setMid
        {
            set
            {
                middleNameDisplay.Text = value;
            }



        }
        public string setR
        {
            set
            {
                regionNum.Text = value;
            }



        }
        public string setC
        {
            set
            {
                cityData.Text = value;
            }
        }
        public string setP
        {
            set
            {
                provinceData.Text = value;
            }



        }
        public string setB
        {
            set
            {
                barangayData.Text = value;
            }



        }
    }
    
    }
