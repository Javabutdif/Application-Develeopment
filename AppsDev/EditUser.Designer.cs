namespace AppsDev
{
    partial class EditUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            civilID = new ComboBox();
            civilReligion = new ComboBox();
            saveBut = new Button();
            civilStatus = new ComboBox();
            civilSex = new ComboBox();
            civilBirthYear = new ComboBox();
            civilBirthDay = new ComboBox();
            label8 = new Label();
            civilPhone = new TextBox();
            label13 = new Label();
            label18 = new Label();
            label10 = new Label();
            label7 = new Label();
            civilBirthMonth = new ComboBox();
            civilEmail = new TextBox();
            label17 = new Label();
            civilIDNumber = new TextBox();
            label16 = new Label();
            label15 = new Label();
            civilAddress = new TextBox();
            label14 = new Label();
            civilBirthPlace = new TextBox();
            label12 = new Label();
            label11 = new Label();
            civilAge = new TextBox();
            label5 = new Label();
            label4 = new Label();
            civilMiddleName = new TextBox();
            label3 = new Label();
            civilFirstName = new TextBox();
            label2 = new Label();
            civilLastName = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // civilID
            // 
            civilID.FormattingEnabled = true;
            civilID.Items.AddRange(new object[] { "e-Card / UMID", "Employee’s ID / Office Id", "Driver’s License", "Professional Regulation Commission (PRC) ID ", "Passport ", "Senior Citizen ID", "SSS ID", "COMELEC / Voter’s ID / COMELEC Registration Form", "Philippine Identification (PhilID / ePhilID)", "NBI Clearance ", "Integrated Bar of the Philippines (IBP) ID", "Firearms License ", "AFPSLAI ID ", "PVAO ID", "AFP Beneficiary ID", "BIR (TIN)", "Pag-ibig ID", "Person’s With Disability (PWD) ID", "Solo Parent ID", "Pantawid Pamilya Pilipino Program (4Ps) ID ", "Barangay ID ", "Philippine Postal ID ", "Phil-health ID", "School ID " });
            civilID.Location = new Point(26, 256);
            civilID.Name = "civilID";
            civilID.Size = new Size(220, 23);
            civilID.TabIndex = 186;
            // 
            // civilReligion
            // 
            civilReligion.FormattingEnabled = true;
            civilReligion.Items.AddRange(new object[] { "Roman Catholic", "Islam", "Iglesia ni Cristo", "Philippine Independent Church", "Seventh-day Adventist", "Bible Baptist Church", "United Church of Christ in the Philippines", "Jehovah's Witnesses", "Church of Christ" });
            civilReligion.Location = new Point(655, 94);
            civilReligion.Name = "civilReligion";
            civilReligion.Size = new Size(135, 23);
            civilReligion.TabIndex = 185;
            // 
            // saveBut
            // 
            saveBut.BackColor = Color.Transparent;
            saveBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBut.ForeColor = Color.White;
            saveBut.Location = new Point(670, 340);
            saveBut.Name = "saveBut";
            saveBut.Size = new Size(120, 31);
            saveBut.TabIndex = 184;
            saveBut.Text = "SAVE";
            saveBut.UseVisualStyleBackColor = false;
            saveBut.Click += saveBut_Click;
            // 
            // civilStatus
            // 
            civilStatus.FormattingEnabled = true;
            civilStatus.Items.AddRange(new object[] { "Single", "Married", "Seperated", "Widowed" });
            civilStatus.Location = new Point(516, 94);
            civilStatus.Name = "civilStatus";
            civilStatus.Size = new Size(117, 23);
            civilStatus.TabIndex = 183;
            // 
            // civilSex
            // 
            civilSex.FormattingEnabled = true;
            civilSex.Items.AddRange(new object[] { "Male", "Female", "Do Not Specify" });
            civilSex.Location = new Point(427, 94);
            civilSex.Name = "civilSex";
            civilSex.Size = new Size(67, 23);
            civilSex.TabIndex = 182;
            // 
            // civilBirthYear
            // 
            civilBirthYear.DropDownHeight = 80;
            civilBirthYear.FormattingEnabled = true;
            civilBirthYear.IntegralHeight = false;
            civilBirthYear.Items.AddRange(new object[] { "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            civilBirthYear.Location = new Point(268, 94);
            civilBirthYear.Name = "civilBirthYear";
            civilBirthYear.Size = new Size(66, 23);
            civilBirthYear.TabIndex = 181;
            civilBirthYear.SelectedIndexChanged += civilBirthYear_SelectedIndexChanged;
            // 
            // civilBirthDay
            // 
            civilBirthDay.DropDownHeight = 80;
            civilBirthDay.FormattingEnabled = true;
            civilBirthDay.IntegralHeight = false;
            civilBirthDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            civilBirthDay.Location = new Point(199, 94);
            civilBirthDay.MaxDropDownItems = 3;
            civilBirthDay.Name = "civilBirthDay";
            civilBirthDay.Size = new Size(47, 23);
            civilBirthDay.TabIndex = 180;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(427, 76);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 179;
            label8.Text = "SEX";
            // 
            // civilPhone
            // 
            civilPhone.Location = new Point(516, 148);
            civilPhone.Name = "civilPhone";
            civilPhone.Size = new Size(117, 23);
            civilPhone.TabIndex = 169;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(516, 130);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 168;
            label13.Text = "PHONE NUMBER";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(359, 76);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 178;
            label18.Text = "AGE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(516, 76);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 164;
            label10.Text = "CIVIL STATUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(268, 76);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 162;
            label7.Text = "YEAR";
            // 
            // civilBirthMonth
            // 
            civilBirthMonth.FormattingEnabled = true;
            civilBirthMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            civilBirthMonth.Location = new Point(26, 94);
            civilBirthMonth.Name = "civilBirthMonth";
            civilBirthMonth.Size = new Size(135, 23);
            civilBirthMonth.TabIndex = 177;
            // 
            // civilEmail
            // 
            civilEmail.Location = new Point(26, 348);
            civilEmail.Name = "civilEmail";
            civilEmail.Size = new Size(222, 23);
            civilEmail.TabIndex = 176;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(26, 330);
            label17.Name = "label17";
            label17.Size = new Size(93, 15);
            label17.TabIndex = 175;
            label17.Text = "EMAIL ADDRESS";
            // 
            // civilIDNumber
            // 
            civilIDNumber.Location = new Point(26, 300);
            civilIDNumber.Name = "civilIDNumber";
            civilIDNumber.Size = new Size(222, 23);
            civilIDNumber.TabIndex = 174;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(26, 282);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 173;
            label16.Text = "ID NUMBER";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(26, 235);
            label15.Name = "label15";
            label15.Size = new Size(146, 15);
            label15.TabIndex = 172;
            label15.Text = "TYPE OF GOVERNMENT ID";
            // 
            // civilAddress
            // 
            civilAddress.Location = new Point(26, 204);
            civilAddress.Name = "civilAddress";
            civilAddress.Size = new Size(448, 23);
            civilAddress.TabIndex = 171;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(26, 186);
            label14.Name = "label14";
            label14.Size = new Size(220, 15);
            label14.TabIndex = 170;
            label14.Text = "ADDRESS(Street, floor, building no., etc):";
            // 
            // civilBirthPlace
            // 
            civilBirthPlace.Location = new Point(26, 148);
            civilBirthPlace.Name = "civilBirthPlace";
            civilBirthPlace.Size = new Size(269, 23);
            civilBirthPlace.TabIndex = 167;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(26, 130);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 166;
            label12.Text = "BIRTH PLACE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(655, 76);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 165;
            label11.Text = "RELIGION";
            // 
            // civilAge
            // 
            civilAge.Location = new Point(359, 94);
            civilAge.Name = "civilAge";
            civilAge.Size = new Size(47, 23);
            civilAge.TabIndex = 163;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(199, 76);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 161;
            label5.Text = "DAY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 76);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 160;
            label4.Text = "BIRTH MONTH";
            // 
            // civilMiddleName
            // 
            civilMiddleName.Location = new Point(359, 38);
            civilMiddleName.Name = "civilMiddleName";
            civilMiddleName.Size = new Size(135, 23);
            civilMiddleName.TabIndex = 159;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(359, 20);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 158;
            label3.Text = "MIDDLE NAME";
            // 
            // civilFirstName
            // 
            civilFirstName.Location = new Point(199, 38);
            civilFirstName.Name = "civilFirstName";
            civilFirstName.Size = new Size(135, 23);
            civilFirstName.TabIndex = 157;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 156;
            label2.Text = "FIRST NAME";
            // 
            // civilLastName
            // 
            civilLastName.Location = new Point(26, 38);
            civilLastName.Name = "civilLastName";
            civilLastName.Size = new Size(135, 23);
            civilLastName.TabIndex = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 154;
            label1.Text = "LAST NAME";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(268, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 153;
            pictureBox2.TabStop = false;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(civilID);
            Controls.Add(civilReligion);
            Controls.Add(saveBut);
            Controls.Add(civilStatus);
            Controls.Add(civilSex);
            Controls.Add(civilBirthYear);
            Controls.Add(civilBirthDay);
            Controls.Add(label8);
            Controls.Add(civilPhone);
            Controls.Add(label13);
            Controls.Add(label18);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(civilBirthMonth);
            Controls.Add(civilEmail);
            Controls.Add(label17);
            Controls.Add(civilIDNumber);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(civilAddress);
            Controls.Add(label14);
            Controls.Add(civilBirthPlace);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(civilAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(civilMiddleName);
            Controls.Add(label3);
            Controls.Add(civilFirstName);
            Controls.Add(label2);
            Controls.Add(civilLastName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "EditUser";
            Size = new Size(816, 390);
            Load += EditUser_Load;
            VisibleChanged += EditUser_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox civilID;
        private ComboBox civilReligion;
        private Button saveBut;
        private ComboBox civilStatus;
        private ComboBox civilSex;
        private ComboBox civilBirthYear;
        private ComboBox civilBirthDay;
        private Label label8;
        private TextBox civilPhone;
        private Label label13;
        private Label label18;
        private Label label10;
        private Label label7;
        private ComboBox civilBirthMonth;
        private TextBox civilEmail;
        private Label label17;
        private TextBox civilIDNumber;
        private Label label16;
        private Label label15;
        private TextBox civilAddress;
        private Label label14;
        private TextBox civilBirthPlace;
        private Label label12;
        private Label label11;
        private TextBox civilAge;
        private Label label5;
        private Label label4;
        private TextBox civilMiddleName;
        private Label label3;
        private TextBox civilFirstName;
        private Label label2;
        private TextBox civilLastName;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
