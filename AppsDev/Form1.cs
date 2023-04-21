using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AppsDev
{

    public partial class Form1 : Form
    {
        public  List<UserLogin> list = new List<UserLogin>();
        public  UserLogin uq = new UserLogin();



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
     

        private void button1_Click(object sender, EventArgs e)
        {
          

            int count;
            for (count = 0; count < File.ReadAllLines(@"D:\Users.txt").Length; count++)
            {
                string[] frag = File.ReadAllText(@"D:\Users.txt").Split("\n");
                string[] us = frag[count].Split(",");

                UserLogin u = new UserLogin(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10]);
                list.Add(u);

            }


            UserLogin? user = list.Where(UserLogin=>UserLogin.username.Equals(getUser)).FirstOrDefault();
            UserLogin? pass = list.Where(UserLogin => UserLogin.password.Equals(getPass)).FirstOrDefault();
            try
            {

                if (user != null && pass != null)
                {
                  
                        
                        textBox1.Text = "";
                        textBox2.Text = "";
                        this.Hide();
                        Form5 dashboard = new Form5();
                        dashboard.Show();
                        dashboard.setID(uq.lastname, uq.firstname, uq.middlename, uq.region, uq.province, uq.city, uq.barangay);

                    
                    
                }
                else
                {
                    MessageBox.Show("Must contain valid username and password");
                }
            }
            catch (Exception ee)
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
        Hover color = new Hover();
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = color.lighter();
            this.button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.White;
            this.button1.ForeColor = color.lighter();

        }
    }
}