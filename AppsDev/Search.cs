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
    public partial class Search : MyBaseForm
    {
        public Search()
        {
            InitializeComponent();
        }
        Hover color = new Hover();

        private void Search_Load(object sender, EventArgs e)
        {
            this.tryAgain.BackColor = color.lighter();
            this.resultDisplay.Visible = false;
            this.resultNot.Visible = false;
            this.tryAgain.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.label1.Visible = false;
                this.textBox1.Visible= false;
                this.button1.Visible = false;
                this.resultDisplay.Visible = true;
            }
            else
            {
                this.label1.Visible = false;
                this.textBox1.Visible = false;
                this.button1.Visible = false;
                this.resultNot.Visible = true;
                this.tryAgain.Visible = true;

            }
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.label1.Visible = true;
            this.textBox1.Visible = true;
            this.button1.Visible = true;
            this.resultNot.Visible = false;
            this.tryAgain.Visible = false;

        }
    }
}
