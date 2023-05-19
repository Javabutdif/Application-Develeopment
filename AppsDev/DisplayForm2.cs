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
    public partial class DisplayForm2 : UserControl
    {
        public DisplayForm2()
        {
            InitializeComponent();
        }
        Civil c = new Civil();

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
            c.deleteAll();
            c.setData();



        }
        Edit edit = new Edit();

        private void DisplayForm_VisibleChanged(object sender, EventArgs e)
        {

            try
            {
                var person = this.Parent as Records;

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
            catch (Exception)
            {

            }
        }


        private static string path = @"C:\Barangay Registration\Database\Citizen.txt";
        private void deleteButton_Click(object sender, EventArgs e)
        {

            DialogResult d;
            d = MessageBox.Show("Do you want to Delete? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {

                SearchTab tab = new SearchTab();

                Civil? user = c.getData().Where(user => user.reference.Equals(displayRef.Text)).FirstOrDefault();

                if (user != null)
                {
                    c.remove(user);

                    string[] arr = c.getData().Select(user => user.reference + "," + user.Lastname + "," + user.Firstname + "," + user.MIDdlename + "," + user.BirthM + "," + user.BirthD + "," + user.BirthYear + "," + user.Age + "," + user.Sex + "," + user.Status + "," + user.Religion + "," + user.BirthPlace + "," + user.PhoneNumber + "," + user.Address + "," + user.identification + "," + user.idNumber + "," + user.Email + "\n").ToArray();
                    c.deleteAll();
                    c.setData();

                    using (StreamWriter write = new StreamWriter(path))
                    {

                        for (int i = 0; i < arr.Length; i++)
                        {
                            write.Write(arr[i]);
                        }

                    }
                    MessageBox.Show("Data Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Visible = false;



                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            edit.Lastname = this.lastnameDisplay.Text;
            edit.Firstname = this.firstnameDisplay.Text;
            edit.MIDdlename = this.middlenameDisplay.Text;
            edit.BirthM = this.birthmonthDisplay.Text;
            edit.BirthD = this.birthdayDisplay.Text;
            edit.BirthYear = this.birthyearDisplay.Text;
            edit.Age = this.ageDisplay.Text;
            edit.Sex = this.sexDisplay.Text;
            edit.Status = this.statusDisplay.Text;
            edit.Religion = this.religionDisplay.Text;
            edit.BirthPlace = this.birthplaceDisplay.Text;
            edit.PhoneNumber = this.phoneDisplay.Text;
            edit.Address = this.addressDisplay.Text;
            edit.identification = this.typeDisplay.Text;
            edit.idNumber = this.idNumDisplay.Text;
            edit.Email = this.emailDisplay.Text;
            edit.reference = this.displayRef.Text;

            edit.Show();


        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show();
        }


    }
}
