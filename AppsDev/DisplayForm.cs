using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppsDev
{
    public partial class DisplayForm : UserControl
    {
        public DisplayForm()
        {
            InitializeComponent();
        }




        Hover color = new Hover();
        private void DisplayForm_Load(object sender, EventArgs e)
        {

           
            //
            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            this.BackColor = color.lighter();
            this.panel1.BackColor = color.lighterDark();
            this.editButton.BackColor = color.lighter();
            this.deleteButton.BackColor = color.lighter();
            this.printButton.BackColor = color.lighter();
            this.backButton.BackColor = color.lighterDark();
            this.panel1.Visible = true;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            

        }

        private void DisplayForm_VisibleChanged(object sender, EventArgs e)
        {
            var person = this.Parent as SearchTab;

            this.lastnameDisplay.Text = person.Lastname;
            this.firstnameDisplay.Text = person.Firstname;
            this.middlenameDisplay.Text = person.MIDdlename;
            this.birthmonthDisplay.Text = person.BirthM;
            this.birthdayDisplay.Text = person.BirthD;
            this.birthyearDisplay.Text = person.BirthYear;
            this.ageDisplay.Text = person.Age;
            this.sexDisplay.Text = person.Sex;
            this.statusDisplay.Text = person.Status;
            this.religionDisplay.Text = person.Religion;
            this.birthplaceDisplay.Text = person.BirthPlace;
            this.phoneDisplay.Text = person.PhoneNumber;
            this.addressDisplay.Text = person.Address;
            this.typeDisplay.Text = person.identification;
            this.idNumDisplay.Text = person.idNumber;
            this.emailDisplay.Text = person.Email;
            this.displayRef.Text = person.reference;

        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
