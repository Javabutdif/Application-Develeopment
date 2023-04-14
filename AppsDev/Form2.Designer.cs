namespace AppsDev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            backBut = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lastName = new TextBox();
            firstName = new TextBox();
            middleName = new TextBox();
            label5 = new Label();
            governID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            regionText = new TextBox();
            provinceText = new TextBox();
            cityText = new TextBox();
            barangayText = new TextBox();
            nextBut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // backBut
            // 
            backBut.BackColor = Color.Transparent;
            backBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backBut.ForeColor = Color.White;
            backBut.Location = new Point(25, 407);
            backBut.Name = "backBut";
            backBut.Size = new Size(120, 31);
            backBut.TabIndex = 0;
            backBut.Text = "BACK";
            backBut.UseVisualStyleBackColor = false;
            backBut.Click += backBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 47);
            label1.TabIndex = 1;
            label1.Text = "CREATE ACCOUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(282, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(196, 72);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "FIRST NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(372, 72);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 6;
            label4.Text = "MIDDLE NAME";
            // 
            // lastName
            // 
            lastName.Location = new Point(25, 88);
            lastName.Name = "lastName";
            lastName.Size = new Size(140, 23);
            lastName.TabIndex = 7;
            // 
            // firstName
            // 
            firstName.Location = new Point(196, 88);
            firstName.Name = "firstName";
            firstName.Size = new Size(140, 23);
            firstName.TabIndex = 8;
            // 
            // middleName
            // 
            middleName.Location = new Point(372, 88);
            middleName.Name = "middleName";
            middleName.Size = new Size(102, 23);
            middleName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 126);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 10;
            label5.Text = "GOVERNMENT ID NUMBER";
            // 
            // governID
            // 
            governID.Location = new Point(25, 144);
            governID.Name = "governID";
            governID.Size = new Size(311, 23);
            governID.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 180);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "REGION";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 231);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 13;
            label7.Text = "PROVINCE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 291);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 14;
            label8.Text = "CITY / MUNICIPALITY";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 347);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 15;
            label9.Text = "BARANGAY";
            // 
            // regionText
            // 
            regionText.Location = new Point(25, 196);
            regionText.Name = "regionText";
            regionText.Size = new Size(140, 23);
            regionText.TabIndex = 16;
            // 
            // provinceText
            // 
            provinceText.Location = new Point(25, 249);
            provinceText.Name = "provinceText";
            provinceText.Size = new Size(140, 23);
            provinceText.TabIndex = 17;
            // 
            // cityText
            // 
            cityText.Location = new Point(25, 309);
            cityText.Name = "cityText";
            cityText.Size = new Size(140, 23);
            cityText.TabIndex = 18;
            // 
            // barangayText
            // 
            barangayText.Location = new Point(25, 365);
            barangayText.Name = "barangayText";
            barangayText.Size = new Size(140, 23);
            barangayText.TabIndex = 19;
            // 
            // nextBut
            // 
            nextBut.BackColor = Color.Transparent;
            nextBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nextBut.ForeColor = Color.White;
            nextBut.Location = new Point(668, 407);
            nextBut.Name = "nextBut";
            nextBut.Size = new Size(120, 31);
            nextBut.TabIndex = 20;
            nextBut.Text = "NEXT ->";
            nextBut.UseVisualStyleBackColor = false;
            nextBut.Click += nextBut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextBut);
            Controls.Add(barangayText);
            Controls.Add(cityText);
            Controls.Add(provinceText);
            Controls.Add(regionText);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(governID);
            Controls.Add(label5);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(backBut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Registration";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBut;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox lastName;
        private TextBox firstName;
        private TextBox middleName;
        private Label label5;
        private TextBox governID;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox regionText;
        private TextBox provinceText;
        private TextBox cityText;
        private TextBox barangayText;
        private Button nextBut;
    }
}