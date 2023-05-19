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

           

            this.label2.BackColor = color.lighterDark();
            this.panel1.BackColor = color.lighterDark();
        }

        public void continueBut_Click(object sender, EventArgs e)
        {

            this.displaySuccess.Text = "";

            this.Visible = false;


        }
        
      
        private void SuccessfulRegis_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                var re = this.Parent as Regis;
                this.displaySuccess.Text = re.Reference;
            }catch (Exception)
            {

            }
            
        }
    }
}
