namespace AppsDev
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.dashB = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.middleNameDash = new System.Windows.Forms.Label();
            this.firstNameDash = new System.Windows.Forms.Label();
            this.lastNameDash = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.dashB);
            this.panel1.Controls.Add(this.records);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 47);
            this.panel1.TabIndex = 0;
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(711, 10);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(80, 23);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "LOG OUT";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(543, 10);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(79, 25);
            this.register.TabIndex = 2;
            this.register.Text = "Register";
            this.register.MouseLeave += new System.EventHandler(this.register_MouseLeave);
            this.register.MouseHover += new System.EventHandler(this.register_MouseHover);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(443, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(69, 25);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            this.search.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // dashB
            // 
            this.dashB.AutoSize = true;
            this.dashB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashB.ForeColor = System.Drawing.Color.White;
            this.dashB.Location = new System.Drawing.Point(157, 10);
            this.dashB.Name = "dashB";
            this.dashB.Size = new System.Drawing.Size(104, 25);
            this.dashB.TabIndex = 2;
            this.dashB.Text = "Dashboard";
            this.dashB.MouseLeave += new System.EventHandler(this.dashL);
            this.dashB.MouseHover += new System.EventHandler(this.dashH);
            // 
            // records
            // 
            this.records.AutoSize = true;
            this.records.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.records.ForeColor = System.Drawing.Color.White;
            this.records.Location = new System.Drawing.Point(289, 10);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(78, 25);
            this.records.TabIndex = 1;
            this.records.Text = "Records";
            this.records.MouseLeave += new System.EventHandler(this.records_MouseLeave);
            this.records.MouseHover += new System.EventHandler(this.records_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppsDev.Properties.Resources.lg;
            this.pictureBox1.Location = new System.Drawing.Point(373, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.middleNameDash);
            this.panel2.Controls.Add(this.firstNameDash);
            this.panel2.Controls.Add(this.lastNameDash);
            this.panel2.Location = new System.Drawing.Point(13, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 352);
            this.panel2.TabIndex = 1;
            // 
            // middleNameDash
            // 
            this.middleNameDash.AutoSize = true;
            this.middleNameDash.ForeColor = System.Drawing.Color.White;
            this.middleNameDash.Location = new System.Drawing.Point(119, 41);
            this.middleNameDash.Name = "middleNameDash";
            this.middleNameDash.Size = new System.Drawing.Size(38, 15);
            this.middleNameDash.TabIndex = 2;
            this.middleNameDash.Text = "label1";
            this.middleNameDash.Click += new System.EventHandler(this.middleNameDash_Click);
            // 
            // firstNameDash
            // 
            this.firstNameDash.AutoSize = true;
            this.firstNameDash.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameDash.ForeColor = System.Drawing.Color.White;
            this.firstNameDash.Location = new System.Drawing.Point(75, 41);
            this.firstNameDash.Name = "firstNameDash";
            this.firstNameDash.Size = new System.Drawing.Size(38, 15);
            this.firstNameDash.TabIndex = 1;
            this.firstNameDash.Text = "label1";
            this.firstNameDash.Click += new System.EventHandler(this.firstNameDash_Click);
            // 
            // lastNameDash
            // 
            this.lastNameDash.AutoSize = true;
            this.lastNameDash.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameDash.ForeColor = System.Drawing.Color.White;
            this.lastNameDash.Location = new System.Drawing.Point(71, 9);
            this.lastNameDash.Name = "lastNameDash";
            this.lastNameDash.Size = new System.Drawing.Size(106, 30);
            this.lastNameDash.TabIndex = 0;
            this.lastNameDash.Text = "LastName";
            this.lastNameDash.Click += new System.EventHandler(this.lastNameDash_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay Registration";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label records;
        private Label dashB;
        private Label register;
        private Label search;
        private Label logOut;
        private Panel panel2;
        private Label lastNameDash;
        private Label middleNameDash;
        private Label firstNameDash;
    }
}