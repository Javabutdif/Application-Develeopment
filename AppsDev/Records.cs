using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppsDev
{
    public partial class Records : UserControl
    {
        public Records()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void Records_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.listBox1.BackColor = color.lighterDark();
            this.displayForm2.Visible = false;
            this.panel1.BackColor = color.lighterDark();
            this.panel1.ForeColor = Color.White;
            this.clearAll.BackColor = color.lighterDark();
            this.clearAll.ForeColor = Color.White;

        }
        Civil c = new Civil();

        private string path = @"C:\Barangay Registration\Database\Citizen.txt";

        private void listView1_VisibleChanged(object sender, EventArgs e)
        {



            this.listBox1.Items.Clear();

            c.setData();
            foreach (Civil cd in c.getData())
            {
                this.listBox1.Items.Add(cd.Lastname + " " + cd.Firstname + " " + cd.MIDdlename + "\t\t\t" + cd.reference);

            }
            if (this.listBox1.Items.Count == 0)
            {
                this.label2.Visible = true;

            }
            else
            {
                this.label2.Visible = false;
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to Clear All the Database? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(path))
                {
                    write.Write("");
                }
                this.listBox1.Items.Clear();

                if (this.listBox1.Items.Count == 0)
                {
                    this.label2.Visible = true;

                }
                else
                {
                    this.label2.Visible = false;
                }

            }

        }

        private void Records_VisibleChanged(object sender, EventArgs e)
        {

        }
        public string data = "";
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            data = this.listBox1.GetItemText(this.listBox1.SelectedItem.ToString());
            string[] arr = data.Split("\t\t\t");

            setLastname(arr[1]);


            this.displayForm2.Visible = true;



        }

        public void setLastname(string last)
        {
            if (c.getList(last) != null)
            {

                Lastname = c.Lastname;
                Firstname = c.Firstname;
                MIDdlename = c.MIDdlename;
                BirthM = c.BirthM;
                BirthD = c.BirthD;
                birthYear = c.BirthYear;
                Age = c.Age;
                Sex = c.Sex;
                Status = c.Status;
                Religion = c.Religion;
                BirthPlace = c.BirthPlace;
                PhoneNumber = c.PhoneNumber;
                Address = c.Address;
                identification = c.identification;
                idNumber = c.idNumber;
                Email = c.Email;
                id = c.reference;

            }
        }

        private string id = "";
        private string lastname = "";
        private string firstname = "";
        private string middlename = "";
        private string birthM = "";
        private string birthDate = "";
        private string birthYear = "";
        private string age = "";
        private string sex = "";
        private string status = "";
        private string religion = "";
        private string birthPlace = "";
        private string phoneNumber = "";
        private string address = "";
        private string ID = "";
        private string idNum = "";
        private string email = "";

        private void displayForm2_VisibleChanged(object sender, EventArgs e)
        {
            EditUser edit = new EditUser();
            if (displayForm2.Visible == false && edit.Visible == false)
            {
                displayForm2.Visible = true;
            }

            this.listBox1.Items.Clear();
            this.data = "";
            c.setData();
            foreach (Civil cd in c.getData())
            {
                this.listBox1.Items.Add(cd.Lastname + " " + cd.Firstname + " " + cd.MIDdlename + "\t\t\t" + cd.reference);

            }
            if (this.listBox1.Items.Count == 0)
            {
                this.label2.Visible = true;

            }
            else
            {
                this.label2.Visible = false;
            }


        }



        public string Lastname { get { return this.lastname; } set { this.lastname = value; } }
        public string Firstname { get { return this.firstname; } set { this.firstname = value; } }
        public string MIDdlename { get { return this.middlename; } set { this.middlename = value; } }
        public string BirthM { get { return this.birthM; } set { this.birthM = value; } }
        public string BirthD { get { return this.birthDate; } set { this.birthDate = value; } }
        public string BirthYear { get { return this.birthYear; } set { this.birthYear = value; } }
        public string BirthPlace { get { return this.birthPlace; } set { this.birthPlace = value; } }
        public string PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string identification { get { return this.ID; } set { this.ID = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string idNumber { get { return this.idNum; } set { this.idNum = value; } }
        public string reference { get { return this.id; } set { this.id = value; } }
        public string Age { get { return this.age; } set { this.age = value; } }
        public string Sex { get { return this.sex; } set { this.sex = value; } }
        public string Religion { get { return this.religion; } set { this.religion = value; } }
        public string Status { get { return this.status; } set { this.status = value; } }

    }
}
