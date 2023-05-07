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
using static System.Windows.Forms.LinkLabel;
using System.IO;

namespace AppsDev
{
    public partial class DisplayForm : UserControl
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private List<Civil> list1 = new List<Civil>();


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
            Civil c = new Civil();
            c.list = list1;


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
       
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to Delete? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
             
               

                SearchTab tab = new SearchTab();




                
                int count;
                for (count = 0; count < File.ReadAllLines(tab.passData).Length; count++)
                {
                    string[] frag = File.ReadAllText(tab.passData).Split("\n");
                    string[] us = frag[count].Split(",");

                    Civil cd = new Civil(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10], us[11], us[12], us[13], us[14], us[15], us[16]);
                    list1.Add(cd);

                }
                

                Civil? user = list1.Where(user => user.Lastname.Equals(lastnameDisplay.Text) ).FirstOrDefault();
             
                if(user!= null)
                {
                    list1.Remove(user);

                    string[] arr = list1.Select(user => user.reference + "," + user.Lastname + "," + user.Firstname + "," + user.MIDdlename + "," + user.BirthM + "," + user.BirthD + "," + user.BirthYear + "," + user.Age + "," + user.Sex + "," + user.Status + "," + user.Religion + "," + user.BirthPlace + "," + user.PhoneNumber + "," + user.Address + "," + user.identification + "," + user.idNumber + "," + user.Email + "\n").ToArray();




                    using (StreamWriter writeData = new StreamWriter(tab.passData))
                    {


                        for (int i = 0; i < list1.Count; i++)
                        {

                          
                            writeData.Write(arr[i]);
                        }

                    }


                }
                
            }
        }
    }
}
