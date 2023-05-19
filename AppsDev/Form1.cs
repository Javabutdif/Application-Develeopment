using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AppsDev
{

    public partial class Form1 : Form
    {
        public List<UserLogin> list = new List<UserLogin>();
        public UserLogin uq = new UserLogin();



        string getUser = "";
        string getPass = "";

        /*
         * Form1 = Login Form
         * Form2 = Admin Registration
         * Form3 = Username and Password Registration
         * Form4 = Successful Page
         * MyBaseForm = Parent Form
         * Dashboard , Searchtab , Regis = UserControl
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

        private static string path = @"C:\Barangay Registration\Admin\";
        private static string database = @"C:\Barangay Registration\Database\";


        private void Form1_Load(object sender, EventArgs e)
        {




            this.BackColor = ColorTranslator.FromHtml("#107874");
            this.panel2.BackColor = ColorTranslator.FromHtml("#062e2c");

          
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            Directory.CreateDirectory(Path.GetDirectoryName(database));



            if (!File.Exists(path + "Users.txt"))
            {
                using (StreamWriter write = new StreamWriter(path + "Users.txt"))
                {
                    write.Write("");
                }
            }
            if (!File.Exists(database + "Citizen.txt"))
            {
                using (StreamWriter write = new StreamWriter(database + "Citizen.txt"))
                {
                    write.Write("");
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            getUser = textBox1.Text;
            getPass = textBox2.Text;

            if (File.Exists(path + "Users.txt"))
            {

                int count;
                for (count = 0; count < File.ReadAllLines(path + "Users.txt").Length; count++)
                {
                    string[] frag = File.ReadAllText(path + "Users.txt").Split("\n");
                    string[] us = frag[count].Split(",");

                    UserLogin u = new UserLogin(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10]);
                    list.Add(u);

                }


                UserLogin? user = list.Where(UserLogin => UserLogin.username.Equals(getUser)).FirstOrDefault();
                UserLogin? pass = list.Where(UserLogin => UserLogin.password.Equals(getPass)).FirstOrDefault();
                try
                {

                    if (user != null && pass != null)
                    {
                        var lastName = user.lastname;
                        var firstName = user.firstname;
                        var middleName = user.middlename;
                        var regionN = user.region;
                        var provinceN = user.province;
                        var cityN = user.city;
                        var barangayN = user.barangay;
                        var id = user.id;

                        textBox1.Text = "";
                        textBox2.Text = "";
                        this.Hide();

                        MyBaseForm parent = new MyBaseForm();
                        parent.getL = lastName;
                        parent.getF = firstName;
                        parent.getM = middleName;
                        parent.getR = regionN;
                        parent.getP = provinceN;
                        parent.getC = cityN;
                        parent.getB = barangayN;






                        MyBaseForm dashboard = new MyBaseForm();
                        dashboard.setUser(id);
                        dashboard.Show();




                    }
                    else
                    {
                        MessageBox.Show("Must contain valid username and password");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Must input correct username and password");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Must contain valid username and password");
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = color.lighter();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}