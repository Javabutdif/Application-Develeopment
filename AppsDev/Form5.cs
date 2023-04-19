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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to log out? ","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(d == DialogResult.OK)
            {
                this.Close();
            }
           
        }

        private void records_MouseHover(object sender, EventArgs e)
        {
            records.BackColor= color.lighter();
        }

        private void records_MouseLeave(object sender, EventArgs e)
        {
            records.BackColor= color.darker();
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor= color.lighter();  
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor= color.darker();   
        }

        private void register_MouseHover(object sender, EventArgs e)
        {
            register.BackColor= color.lighter();    
        }

        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor= color.darker();   
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            this.panel1.BackColor = color.darker();
            this.BackColor = color.lighter();
            this.panel2.BackColor = color.lightDark();
        }
    }
}
