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
        private string reference;
        private string citizenInfo = "";
        private void registerBut_Click(object sender, EventArgs e)
        {
            Reference = getID();
            
           
            citizenInfo =Reference+","+ civilLastName.Text + "," + civilFirstName.Text + "," + civilMiddleName.Text + "," + civilBirthMonth.Text + "," + civilBirthDay.Text + "," + civilBirthYear.Text + "," + civilAge.Text + "," + civilSex.Text + "," + civilStatus.Text + "," + civilReligion.Text + "," + civilBirthPlace.Text + "," + civilPhone.Text + "," + civilAddress.Text + "," + civilID.Text + "," + civilIDNumber.Text + "," + civilEmail.Text;
            


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
        public string Reference { set { reference = value; } get { return reference; } }



      


    }
}
