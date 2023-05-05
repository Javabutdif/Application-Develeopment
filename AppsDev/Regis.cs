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


        private void civilBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(civilBirthYear.Text);
            civilAge.Text = Convert.ToString(2023 - year);
        }

        private void registerBut_Click(object sender, EventArgs e)
        {
            this.successfulRegis1.Visible = true;


        }
    }
}
