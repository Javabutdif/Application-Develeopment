namespace AppsDev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(565, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(585, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 455);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(121, 321);
            linkLabel1.Margin = new Padding(1, 0, 3, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(44, 12);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 321);
            label3.Name = "label3";
            label3.Size = new Size(62, 12);
            label3.TabIndex = 7;
            label3.Text = "New Account?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(72, 269);
            button1.Name = "button1";
            button1.Size = new Size(86, 49);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 216);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password...";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 166);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username/Login...";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.aaaaaa;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseHover += pictureBox3_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = Properties.Resources.LOGO;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-433, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 81);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(802, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 489);
            MinimumSize = new Size(818, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Registration";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox3;
    }
}