﻿using Microsoft.Win32;
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

        }

        private void dashB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
