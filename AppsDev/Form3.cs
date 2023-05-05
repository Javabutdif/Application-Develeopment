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
        private Form2 previous;
        public Form3(Form2 form)
        {
            InitializeComponent();
            backBut.BackColor = ColorTranslator.FromHtml("#107874");
            signUp.BackColor = ColorTranslator.FromHtml("#107874");
            previous = form;
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
            Form2 form2 = new Form2(previous);
            form2.Show();
            this.Close();
        }
        Form2 getR = new Form2();

        private static string path = @"D:\Barangay Registration\Admin\";
        private void signUp_Click(object sender, EventArgs e)
        {
            if (userIn != "" && passIn != "")
            {
                if (passIn.Equals(confirm))
                {

                
              

                    Users admin = new Users(getR.getReference(), userIn, passIn, Form2.firstInfo);
                    string[] lines = File.ReadAllLines(path + "Users.txt");

                    using (StreamWriter writeData = new StreamWriter(path + "Users.txt"))
                        {

                            
                            for (int i = 0; i < lines.Length; i++)
                            {
                                writeData.WriteLine(lines[i]);
                            }
                            writeData.WriteLine(admin.getData());
                        }



                    
                
               
                    


                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Confirm Password");

                }
            }
            else
            {
                MessageBox.Show("Must contain username and password");

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

        private void confirmPass_Validating(object sender, CancelEventArgs e)
        {
            Validate1();
        }
        private bool Validate1()
        {
            bool valid = true;

            if (!passIn.Equals(confirm))
            {
                errorProvider1.SetError(confirmPass, "Please enter again ");
                valid = false;
            }
            else
                errorProvider1.SetError(confirmPass, "");

            return valid;

        }
    }
}
