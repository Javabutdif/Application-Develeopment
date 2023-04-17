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
    public partial class Form2 : Form
    {
        private Form previous;

        public Form2(Form form)
        {
            InitializeComponent();
            backBut.BackColor = ColorTranslator.FromHtml("#107874");
            nextBut.BackColor = ColorTranslator.FromHtml("#107874");
            previous = form;


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#107874");
        }


        private void backBut_Click(object sender, EventArgs e)
        {


            this.Close();
            previous.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            if (lastName.Text != "" && firstName.Text != "" && middleName.Text != "" && governID.Text != "" && regionText.Text != "" && provinceText.Text != "" && cityText.Text != "" && barangayText.Text != "")
            {
                string accountName = @"D:\" + lastName.Text + ".txt";
                using (StreamWriter write = new StreamWriter(accountName))
                {
                    write.WriteLine(lastName.Text + " " + firstName.Text + " " + middleName.Text + " " + governID.Text + " " + regionText.Text + " " + provinceText.Text + " " + cityText.Text + " " + barangayText.Text);
                }

                Form3 form3 = new Form3(this);                     
                form3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Must complete the account");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
