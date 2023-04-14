using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AppsDev
{
   
    public partial class Form1 : Form
    {
      

        private string userName = File.ReadAllText(@"C:\Users\james\desktop\Application\AppsDev\Database\userNameRecord.txt");
        private string passWord = "123";



        public Form1()
        {
            InitializeComponent();
            button1.ForeColor = ColorTranslator.FromHtml("#107874");
            linkLabel1.LinkColor = ColorTranslator.FromHtml("#00FFF5");




        }
        string getUser = "";
        string getPass = "";


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
            if (getUser.Equals(userName) && getPass.Equals(passWord))
            {
                MessageBox.Show("Login In");
            }
            else
            {
                MessageBox.Show("Invalid");
                MessageBox.Show(userName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Close();
            Form2 form2 = new Form2();
            form2.Show();


        }
    }
}