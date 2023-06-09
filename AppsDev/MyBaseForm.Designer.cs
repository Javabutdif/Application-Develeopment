﻿namespace AppsDev
{
    partial class MyBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBaseForm));
            panel2 = new Panel();
            logOut = new Label();
            register = new Label();
            search = new Label();
            dashB = new Label();
            records = new Label();
            pictureBox1 = new PictureBox();
            label = new Label();
            userNameData = new Label();
            dashboard1 = new Dashboard();
            searchTab1 = new SearchTab();
            regis1 = new Regis();
            records1 = new Records();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(logOut);
            panel2.Controls.Add(register);
            panel2.Controls.Add(search);
            panel2.Controls.Add(dashB);
            panel2.Controls.Add(records);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 53);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logOut
            // 
            logOut.AutoSize = true;
            logOut.BorderStyle = BorderStyle.FixedSingle;
            logOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOut.ForeColor = Color.White;
            logOut.Location = new Point(708, 16);
            logOut.Name = "logOut";
            logOut.Size = new Size(80, 23);
            logOut.TabIndex = 4;
            logOut.Text = "LOG OUT";
            logOut.Click += logOut_Click;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register.ForeColor = Color.White;
            register.Location = new Point(539, 14);
            register.Name = "register";
            register.Size = new Size(79, 25);
            register.TabIndex = 2;
            register.Text = "Register";
            register.Click += register_Click;
            register.MouseLeave += register_MouseLeave;
            register.MouseHover += register_MouseHover;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.White;
            search.Location = new Point(439, 14);
            search.Name = "search";
            search.Size = new Size(69, 25);
            search.TabIndex = 3;
            search.Text = "Search";
            search.Click += search_Click;
            search.MouseLeave += search_MouseLeave;
            search.MouseHover += search_MouseHover;
            // 
            // dashB
            // 
            dashB.AutoSize = true;
            dashB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dashB.ForeColor = Color.White;
            dashB.Location = new Point(153, 14);
            dashB.Name = "dashB";
            dashB.Size = new Size(104, 25);
            dashB.TabIndex = 2;
            dashB.Text = "Dashboard";
            dashB.Click += dashB_Click;
            dashB.MouseLeave += dashL;
            dashB.MouseHover += dashH;
            // 
            // records
            // 
            records.AutoSize = true;
            records.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            records.ForeColor = Color.White;
            records.Location = new Point(285, 14);
            records.Name = "records";
            records.Size = new Size(78, 25);
            records.TabIndex = 1;
            records.Text = "Records";
            records.Click += records_Click;
            records.MouseLeave += records_MouseLeave;
            records.MouseHover += records_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lg;
            pictureBox1.Location = new Point(373, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(24, 428);
            label.Name = "label";
            label.Size = new Size(68, 13);
            label.TabIndex = 6;
            label.Text = "USERNAME";
            // 
            // userNameData
            // 
            userNameData.AutoSize = true;
            userNameData.ForeColor = Color.White;
            userNameData.Location = new Point(98, 428);
            userNameData.Name = "userNameData";
            userNameData.Size = new Size(0, 15);
            userNameData.TabIndex = 7;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(16, 120, 116);
            dashboard1.Location = new Point(0, 41);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(801, 384);
            dashboard1.TabIndex = 8;
            // 
            // searchTab1
            // 
            searchTab1.Address = "";
            searchTab1.Age = "";
            searchTab1.BackColor = Color.FromArgb(16, 120, 116);
            searchTab1.BirthD = "";
            searchTab1.BirthM = "";
            searchTab1.BirthPlace = "";
            searchTab1.BirthYear = "";
            searchTab1.Email = "";
            searchTab1.Firstname = "";
            searchTab1.identification = "";
            searchTab1.idNumber = "";
            searchTab1.Lastname = "";
            searchTab1.Location = new Point(0, 41);
            searchTab1.MIDdlename = "";
            searchTab1.Name = "searchTab1";
            searchTab1.passData = "";
            searchTab1.PhoneNumber = "";
            searchTab1.reference = "";
            searchTab1.Religion = "";
            searchTab1.Sex = "";
            searchTab1.Size = new Size(816, 390);
            searchTab1.Status = "";
            searchTab1.TabIndex = 9;
            // 
            // regis1
            // 
            regis1.BackColor = Color.FromArgb(16, 120, 116);
            regis1.getInfo = "";
            regis1.Location = new Point(0, 51);
            regis1.Name = "regis1";
            regis1.Reference = null;
            regis1.Size = new Size(816, 367);
            regis1.TabIndex = 5;
            // 
            // records1
            // 
            records1.Address = "";
            records1.Age = "";
            records1.BackColor = Color.FromArgb(16, 120, 116);
            records1.BirthD = "";
            records1.BirthM = "";
            records1.BirthPlace = "";
            records1.BirthYear = "";
            records1.Email = "";
            records1.Firstname = "";
            records1.identification = "";
            records1.idNumber = "";
            records1.Lastname = "";
            records1.Location = new Point(0, 48);
            records1.MIDdlename = "";
            records1.Name = "records1";
            records1.PhoneNumber = "";
            records1.reference = "";
            records1.Religion = "";
            records1.Sex = "";
            records1.Size = new Size(816, 370);
            records1.Status = "";
            records1.TabIndex = 10;
            // 
            // MyBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(records1);
            Controls.Add(regis1);
            Controls.Add(label);
            Controls.Add(userNameData);
            Controls.Add(panel2);
            Controls.Add(searchTab1);
            Controls.Add(dashboard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MyBaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Registration";
            Load += MyBaseForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label logOut;
        private Label register;
        private Label search;
        private Label dashB;
        private Label records;
        private PictureBox pictureBox1;
        private Label label;
        private Label userNameData;
        private Dashboard dashboard1;
        private SearchTab searchTab1;
        private Regis regis1;
        private Records records1;
    }
}