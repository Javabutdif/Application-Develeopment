﻿namespace AppsDev
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
            this.logOut = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.dashB = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lastNameDash = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
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
            // panel12
            // 
            this.panel12.Controls.Add(this.lastNameDash);
            this.panel12.Location = new System.Drawing.Point(13, 63);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 352);
            this.panel12.TabIndex = 1;
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
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(13, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 66);
            this.panel3.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay Registration";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Controls.SetChildIndex(this.panel12, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Label records;
        private Label dashB;
        private Label register;
        private Label search;
        private Label logOut;
        private Panel panel12;
        private Label lastNameDash;
        private Panel panel3;
    }
}