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

        private static string path = @"C:\Barangay Registration\Admin\";
        private List<UserLogin> list = new List<UserLogin>();
        private void signUp_Click(object sender, EventArgs e)
        {


            if (userIn != "" && passIn != "")
            {
                int count;
                for (count = 0; count < File.ReadAllLines(path + "Users.txt").Length; count++)
                {
                    string[] frag = File.ReadAllText(path + "Users.txt").Split("\n");
                    string[] us = frag[count].Split(",");

                    UserLogin u = new UserLogin(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10]);
                    list.Add(u);

                }


                UserLogin? user = list.Where(UserLogin => UserLogin.username.Equals(userIn)).FirstOrDefault();
                if (user == null)
                {
                    if (passIn.Equals(confirm))
                    {




                        Users admin = new Users(getR.getReference(), userIn, passIn, getR.firstinfo);
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
                        MessageBox.Show("Invalid Confirm Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Username already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Must contain username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
