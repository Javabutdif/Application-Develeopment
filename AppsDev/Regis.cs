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
    public partial class Regis : UserControl
    {
        public Regis()
        {
            InitializeComponent();
        }



        Hover color = new Hover();
        private void Regis_Load(object sender, EventArgs e)
        {
            this.BackColor = color.lighter();
            this.successfulRegis1.Visible = false;
            this.registerBut.BackColor = color.lighter();
            this.clearSelection.BackColor = color.lighter();
            this.clearSelection.ForeColor = Color.White;




        }
        private void clearSelection_Click(object sender, EventArgs e)
        {
            this.civilAddress.Text = "";
            this.civilAge.Text = "";
            this.civilBirthDay.Text = "";
            this.civilBirthMonth.Text = "";
            this.civilBirthPlace.Text = "";
            this.civilBirthYear.Text = "";
            this.civilEmail.Text = "";
            this.civilFirstName.Text = "";
            this.civilID.Text = "";
            this.civilIDNumber.Text = "";
            this.civilLastName.Text = "";
            this.civilMiddleName.Text = "";
            this.civilPhone.Text = "";
            this.civilReligion.Text = "";
            this.civilSex.Text = "";
            this.civilStatus.Text = "";



        }
        public static string getID()
        {
            Random rand = new Random();
            string reference = "";
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();

            for (int i = 0; i < 8; i++)
            {
                reference += letters[rand.Next(letters.Length)];
            }

            return reference;
        }



        private void civilBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(civilBirthYear.Text);
            civilAge.Text = Convert.ToString(2023 - year);
        }
        private static string path = @"C:\Barangay Registration\Database\";
        private static string reference = "";
        private string citizenInfo = "";
        private void registerBut_Click(object sender, EventArgs e)
        {
            string ln = this.civilLastName.Text;
            string fn = this.civilFirstName.Text;
            string mn = this.civilMiddleName.Text;
            string bm = this.civilBirthMonth.Text;
            string bd = this.civilBirthDay.Text;
            string by = this.civilBirthYear.Text;
            string age = this.civilAge.Text;
            string sex = this.civilSex.Text;
            string status = this.civilStatus.Text;
            string r = this.civilReligion.Text;
            string bp = this.civilBirthPlace.Text;
            string pn = this.civilPhone.Text;
            string add = this.civilAddress.Text;
            string type = this.civilID.Text;
            string idN = this.civilIDNumber.Text;
            string email = this.civilEmail.Text;

            if (ln.Equals(string.Empty) || fn.Equals(string.Empty) || mn.Equals(string.Empty) || email.Equals(string.Empty) || bm.Equals(string.Empty) || bd.Equals(string.Empty) || by.Equals(string.Empty) || age.Equals(string.Empty) || sex.Equals(string.Empty) || status.Equals(string.Empty) || r.Equals(string.Empty) || bp.Equals(string.Empty) || pn.Equals(string.Empty) || add.Equals(string.Empty) || type.Equals(string.Empty) || idN.Equals(string.Empty))
            {
                MessageBox.Show("Please complete necessary Information!");
            }
            else {
               
                    Reference = getID();


                    citizenInfo = Reference + "," + civilLastName.Text + "," + civilFirstName.Text + "," + civilMiddleName.Text + "," + civilBirthMonth.Text + "," + civilBirthDay.Text + "," + civilBirthYear.Text + "," + civilAge.Text + "," + civilSex.Text + "," + civilStatus.Text + "," + civilReligion.Text + "," + civilBirthPlace.Text + "," + civilPhone.Text + "," + civilAddress.Text + "," + civilID.Text + "," + civilIDNumber.Text + "," + civilEmail.Text;
                    getInfo = civilLastName.Text + ", " + civilFirstName.Text;


                    string[] lines = File.ReadAllLines(path + "Citizen.txt");

                    using (StreamWriter writeData = new StreamWriter(path + "Citizen.txt"))
                    {


                        for (int i = 0; i < lines.Length; i++)
                        {
                            writeData.WriteLine(lines[i]);
                        }
                        writeData.WriteLine(citizenInfo);
                    }
                    this.successfulRegis1.Visible = true;
                
               
            }


        }
        private static string info = "";
        public string Reference { set { reference = value; } get { return reference; } }

        public string getInfo { set { info = value; } get { return info; } }

        private bool Validate1()
        {
            bool valid = true;

            if (civilLastName.Text == "")
            {
                errorProvider1.SetError(civilLastName, "Please enter again ");
                valid = false;
            }
            else
                errorProvider1.SetError(civilLastName, "");

            return valid;

        }


    }
}
