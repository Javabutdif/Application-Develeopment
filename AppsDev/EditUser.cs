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

namespace AppsDev
{
    public partial class EditUser : UserControl
    {
        public EditUser()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private static string path = @"C:\Barangay Registration\Database\Citizen.txt";
        private void EditUser_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.saveBut.BackColor = color.lighter();
        }
        private static string id = "";
        private static string lastname = "";
        private static string firstname = "";
        private static string middlename = "";
        private static string birthM = "";
        private static string birthDate = "";
        private static string birthYear = "";
        private static string age = "";
        private static string sex = "";
        private static string status = "";
        private static string religion = "";
        private static string birthPlace = "";
        private static string phoneNumber = "";
        private static string address = "";
        private static string ID = "";
        private static string idNum = "";
        private static string email = "";
        private static string reference1 = "";



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
            Civil? user = c.getData().Where(user => user.reference.Equals(reference1)).FirstOrDefault();

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

            MessageBox.Show("Data Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Visible = false;
           
          

        }

        private void civilBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(civilBirthYear.Text);
            civilAge.Text = Convert.ToString(2023 - year);
        }

        private void EditUser_VisibleChanged(object sender, EventArgs e)
        {
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
            reference1 = reference;
        }

        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string MIDdlename { get { return middlename; } set { middlename = value; } }
        public string BirthM { get { return birthM; } set { birthM = value; } }
        public string BirthD { get { return birthDate; } set { birthDate = value; } }
        public string BirthYear { get { return birthYear; } set { birthYear = value; } }
        public string BirthPlace { get { return birthPlace; } set { birthPlace = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string identification { get { return ID; } set { ID = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string idNumber { get { return idNum; } set { idNum = value; } }
        public string reference { get { return id; } set { id = value; } }
        public string Age { get { return age; } set { age = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public string Religion { get { return religion; } set { religion = value; } }
        public string Status { get { return status; } set { status = value; } }
    }
}
