using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDev
{
    public partial class MyBaseForm : Form
    {

        public MyBaseForm()
        {
            InitializeComponent();


        }
        private static string ln;
        private static string fn;
        private static string mn;
        private static string r;
        private static string p;
        private static string c;
        private static string b;


        public string setL
        {
            set
            {
                ln = value;
            }
        }
        public string setF
        {
            set
            {
                fn = value;
            }
        }
        public string setM
        {
            set
            {
                mn = value;
            }
        }
        public string setR
        {
            set
            {
                r = value;
            }
        }
        public string setP
        {
            set
            {
                p = value;
            }
        }
        public string setC
        {
            set
            {
                c = value;
            }
        }
        public string setB
        {
            set
            {
                b = value;
            }
        }
        public string getL
        {
            get
            {
                return ln;
            }
        }
        public string getF
        {
            get
            {
                return fn;
            }
        }
        public string getM
        {
            get
            {
                return mn;
            }
        }
        public string getR
        {
            get
            {
                return r;
            }
        }
        public string getP
        {
            get
            {
                return p;
            }
        }
        public string getC
        {
            get
            {
                return c;
            }
        }
        public string getB
        {
            get
            {
                return b;
            }
        }




        Hover color = new Hover();






        private void dashH(object sender, EventArgs e)
        {
            dashB.BackColor = color.lighter();

        }
        private void dashL(object sender, EventArgs e)
        {
            dashB.BackColor = color.darker();
        }
        public void setUser(string id)
        {
            this.label.Text = id;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to log out? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
            }

        }

        private void records_MouseHover(object sender, EventArgs e)
        {
            records.BackColor = color.lighter();
        }

        private void records_MouseLeave(object sender, EventArgs e)
        {
            records.BackColor = color.darker();
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = color.lighter();
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = color.darker();
        }

        private void register_MouseHover(object sender, EventArgs e)
        {
            register.BackColor = color.lighter();
        }

        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor = color.darker();
        }




        private void MyBaseForm_Load(object sender, EventArgs e)
        {

            this.BackColor = color.lighter();
            this.panel2.BackColor = color.darker();
            searchTab1.Visible = false;
            dashboard1.Visible = true;
            regis1.Visible = false;



        }

        private void dashB_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            searchTab1.Visible = false;
            regis1.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            searchTab1.Visible = true;
            regis1.Visible = false;



        }

        private void register_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            searchTab1.Visible = false;
            regis1.Visible = true;

        }

       
    }
}
