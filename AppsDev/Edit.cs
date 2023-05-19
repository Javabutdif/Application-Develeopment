using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices.ActiveDirectory;

namespace AppsDev
{
    public partial class Edit : Form
    {

        public Edit()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private string reference1 = "";
        private void Edit_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.saveBut.BackColor = color.lighter();



            this.civilLastName.Text = Lastname;
            this.civilFirstName.Text = Firstname;
            this.civilMiddleName.Text = MIDdlename;
            this.civilBirthMonth.Text = BirthM;
            this.civilBirthDay.Text = BirthD;
            this.civilBirthYear.Text = BirthYear;
            this.civilAge.Text = Age;
            this.civilSex.Text = Sex;
            this.civilStatus.Text = Status;
            this.civilReligion.Text = Religion;
            this.civilBirthPlace.Text = BirthPlace;
            this.civilPhone.Text = PhoneNumber;
            this.civilAddress.Text = Address;
            this.civilID.Text = identification;
            this.civilIDNumber.Text = idNumber;
            this.civilEmail.Text = Email;
            this.reference1 = reference;

        }
        private static string path = @"C:\Barangay Registration\Database\Citizen.txt";
        private void saveBut_Click(object sender, EventArgs e)
        {
            Lastname = this.civilLastName.Text;
            Firstname = this.civilFirstName.Text;
            MIDdlename = this.civilMiddleName.Text;
            BirthM = this.civilBirthMonth.Text;
            BirthD = this.civilBirthDay.Text;
            BirthYear = this.civilBirthYear.Text;
            Age = this.civilAge.Text;
            Sex = this.civilSex.Text;
            Status = this.civilStatus.Text;
            Religion = this.civilReligion.Text;
            BirthPlace = this.civilBirthPlace.Text;
            PhoneNumber = this.civilPhone.Text;
            Address = this.civilAddress.Text;
            identification = this.civilID.Text;
            idNumber = this.civilIDNumber.Text;
            Email = this.civilEmail.Text;

            Civil c = new Civil();
            SearchTab tab = new SearchTab();
            Civil? user = c.getData().Where(user => user.reference.Equals(this.reference1)).FirstOrDefault();

            if (user != null)
            {
                c.remove(user);
                string citizenInfo = reference1 + "," + civilLastName.Text + "," + civilFirstName.Text + "," + civilMiddleName.Text + "," + civilBirthMonth.Text + "," + civilBirthDay.Text + "," + civilBirthYear.Text + "," + civilAge.Text + "," + civilSex.Text + "," + civilStatus.Text + "," + civilReligion.Text + "," + civilBirthPlace.Text + "," + civilPhone.Text + "," + civilAddress.Text + "," + civilID.Text + "," + civilIDNumber.Text + "," + civilEmail.Text;
                string[] arr = c.getData().Select(user => user.reference + "," + user.Lastname + "," + user.Firstname + "," + user.MIDdlename + "," + user.BirthM + "," + user.BirthD + "," + user.BirthYear + "," + user.Age + "," + user.Sex + "," + user.Status + "," + user.Religion + "," + user.BirthPlace + "," + user.PhoneNumber + "," + user.Address + "," + user.identification + "," + user.idNumber + "," + user.Email + "\n").ToArray();
                c.deleteAll();
                c.setData();

                using (StreamWriter write = new StreamWriter(path))
                {

                    for (int i = 0; i < arr.Length; i++)
                    {
                        write.Write(arr[i]);
                    }
                    write.Write(citizenInfo + "\n");

                }




            }

            MessageBox.Show("Data Saved","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
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
     

        private void civilBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(civilBirthYear.Text);
            civilAge.Text = Convert.ToString(2023 - year);
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
          
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
