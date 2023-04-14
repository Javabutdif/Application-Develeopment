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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            backBut.BackColor  = ColorTranslator.FromHtml("#107874");
          

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#107874");
        }
       

        private void backBut_Click(object sender, EventArgs e)
        {
            

            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
