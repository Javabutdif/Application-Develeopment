using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
    public partial class Form5 : MyBaseForm
    {


        Hover color = new Hover();
        public Form5()
        {
            InitializeComponent();



        }
        static string lastN = "";
        static string fn = "";
        static string md = "";
        static string r = "";
        static string c = "";
        static string p = "";
        static string b = "";



        public  void setID(string lastname, string firstname, string middlename, string region, string province, string city, string barangay)
        {
            lastN = lastname;
            fn = firstname;
            middleNameDisplay.Text = middlename;
            regionDisplay.Text = region;
            cityDisplay.Text = city;
            provinceDisplay.Text = province;
            barangayDisplay.Text = barangay;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            this.panel3.BackColor = color.lighter();
            this.panel12.BackColor = color.lightDark();
            this.panel1.BackColor = color.lightDark();
            this.panel4.BackColor = color.lightDark();
            this.panel5.BackColor = color.lighterDark();
          
        }
    }
}
