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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            backBut.BackColor = ColorTranslator.FromHtml("#107874");
            signUp.BackColor = ColorTranslator.FromHtml("#107874");

        }
        string userIn = "";
        string passIn = "";
        string confirm = "";







        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#107874");
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (passIn.Equals(confirm))
            {

                new Form1(userIn, passIn);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Confirm Password");

            }
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            userIn = userInput.Text;
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            passIn = newPass.Text;
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            confirm = confirmPass.Text;
        }
    }
}
