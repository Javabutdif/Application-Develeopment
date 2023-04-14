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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
           
            logIn.BackColor = ColorTranslator.FromHtml("#107874");


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#107874");

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
