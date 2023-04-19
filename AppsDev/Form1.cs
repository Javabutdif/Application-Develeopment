using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AppsDev
{
   
    public partial class Form1 : Form
    {
       
        string getUser = "";
        string getPass = "";

        /*
         * Form1 = Login Form
         * Form2 = Admin Registration
         * Form3 = Username and Password Registration
         * Form4 = Successful Page
         * Form5 = Dashboard
         * 
         * 
         * 
         * 
         * 
         * 
         */

      



        public Form1()
        {
            InitializeComponent();
            button1.ForeColor = ColorTranslator.FromHtml("#107874");
            linkLabel1.LinkColor = ColorTranslator.FromHtml("#00FFF5");




        }
       


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#107874");
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#062e2c");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_TextChanged != null)
            {
                label1.Visible = false;
            }
            if (textBox1.Text.Equals(""))
            {
                label1.Visible = true;
            }
            getUser = textBox1.Text;

           

        }
     


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2_TextChanged != null)
            {
                label2.Visible = false;
            }
            if (textBox2.Text.Equals(""))
            {
                label2.Visible = true;
            }
            getPass = textBox2.Text;
        }
       static Class2 loc = new Class2();
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (getUser != "" && getPass != "")
                {
                    if (File.ReadAllText(loc.getLocation() + getUser + ".txt").Equals(File.ReadAllText(loc.getLocation() + getPass + ".txt")))
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        Form5 dashboard = new Form5();
                        dashboard.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Must contain valid username and password");
                }
            }catch(Exception ee)
            {
                MessageBox.Show("Must input correct username and password");
                textBox1.Text = "";
                textBox2.Text = "";
            }
         
          

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(this);
            form2.Show();


        }
    }
}