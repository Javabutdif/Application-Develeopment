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
    public partial class SearchTab : UserControl
    {
        public SearchTab()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void SearchTab_Load(object sender, EventArgs e)
        {
            this.tryAgain.BackColor = color.lighter();
            this.BackColor = color.lighter();
            this.resultDisplay.Visible = false;
            this.resultNot.Visible = false;
            this.tryAgain.Visible = false;
            this.panel1.Visible = false;
            this.displayForm1.Visible = false;

        }
        private static string path = @"C:\Barangay Registration\Database\";
        Civil person = new Civil();
        private void button1_Click(object sender, EventArgs e)
        {
            
            passData = path + "Citizen.txt";
            person.setData();

            if (File.Exists(path + "Citizen.txt"))
            {
                try
                {

                    if (person.getList(textBox1.Text) != null)
                    {


                        this.panel1.Visible = true;
                        this.resultDisplay.Visible = true;



                        this.displayName.Text = person.Lastname + ", " + person.Firstname + " " + person.MIDdlename;
                        this.refCode.Text = "REF: " + person.reference;

                        Lastname = person.Lastname;
                        Firstname = person.Firstname;
                        MIDdlename = person.MIDdlename;
                        BirthM = person.BirthM;
                        BirthD = person.BirthD;
                        birthYear = person.BirthYear;
                        Age = person.Age;
                        Sex = person.Sex;
                        Status = person.Status;
                        Religion = person.Religion;
                        BirthPlace = person.BirthPlace;
                        PhoneNumber = person.PhoneNumber;
                        Address = person.Address;
                        identification = person.identification;
                        idNumber = person.idNumber;
                        Email = person.Email;

                    }
                    else
                    {
                        this.label1.Visible = false;
                        this.textBox1.Visible = false;
                        this.button1.Visible = false;
                        this.resultNot.Visible = true;
                        this.tryAgain.Visible = true;
                        this.resultDisplay.Visible = false;
                        this.panel1.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    this.label1.Visible = false;
                    this.textBox1.Visible = false;
                    this.button1.Visible = false;
                    this.resultNot.Visible = true;
                    this.tryAgain.Visible = true;
                    this.resultDisplay.Visible = false;
                    this.panel1.Visible = false;
                }

            }

            else
            {
                this.label1.Visible = false;
                this.textBox1.Visible = false;
                this.button1.Visible = false;
                this.resultNot.Visible = true;
                this.tryAgain.Visible = true;
                this.resultDisplay.Visible = false;
                this.panel1.Visible = false;
            }




        }
        private static string data = "";
        public string passData { set { data = value; } get { return data; } }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.label1.Visible = true;
            this.textBox1.Visible = true;
            this.button1.Visible = true;
            this.resultNot.Visible = false;
            this.tryAgain.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.resultDisplay.Visible = false;
            this.panel1.Visible = false;


        }



        private void panel1_Click(object sender, EventArgs e)
        {
            this.displayForm1.Visible = true;
        }

        private void displayName_Click(object sender, EventArgs e)
        {
            this.displayForm1.Visible = true;
            
        }
        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */
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
