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
    public partial class SearchTab : UserControl
    {
        public SearchTab()
        {
            InitializeComponent();
        }
        Hover color = new Hover();
        private void SearchTab_Load(object sender, EventArgs e)
        {
            this.tryAgain.BackColor = color.lighter();
            this.BackColor = color.lighter();
            this.resultDisplay.Visible = false;
            this.resultNot.Visible = false;
            this.tryAgain.Visible = false;
            this.panel1.Visible = false;

        }
        private static string path = @"C:\Barangay Registration\Database\";
        private void button1_Click(object sender, EventArgs e)
        {
            Civil person = new Civil();
            passData = path + "Citizen.txt";
            person.setData();

              if (File.Exists(path +  "Citizen.txt"))
                {
                try
                {
                    person.getList(textBox1.Text);


                    this.panel1.Visible = true;
                    this.resultDisplay.Visible = true;



                    this.displayName.Text = person.Lastname + ", " + person.Firstname +" "+ person.MIDdlename;
                    this.refCode.Text = "REF: " + person.reference;



                }
                catch(Exception ex)
                {
                    this.label1.Visible = false;
                    this.textBox1.Visible = false;
                    this.button1.Visible = false;
                    this.resultNot.Visible = true;
                    this.tryAgain.Visible = true;
                    this.resultDisplay.Visible = false;
                    this.panel1.Visible = false;
                }
                     
                }

                else
                {
                    this.label1.Visible = false;
                    this.textBox1.Visible = false;
                    this.button1.Visible = false;
                    this.resultNot.Visible = true;
                    this.tryAgain.Visible = true;
                    this.resultDisplay.Visible = false;
                    this.panel1.Visible = false;
                }
        

            
          
        }
        private static string data = "";
        public string passData { set { data = value; } get { return data; } }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.label1.Visible = true;
            this.textBox1.Visible = true;
            this.button1.Visible = true;
            this.resultNot.Visible = false;
            this.tryAgain.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                this.resultDisplay.Visible = false;
                this.panel1.Visible = false;
            
               
        }
    }
}
