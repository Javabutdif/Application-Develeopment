namespace AppsDev
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.dashB = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameData = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logOut);
            this.panel2.Controls.Add(this.register);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.dashB);
            this.panel2.Controls.Add(this.records);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 47);
            this.panel2.TabIndex = 1;
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
            this.register.Click += new System.EventHandler(this.register_Click);
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
            this.search.Click += new System.EventHandler(this.search_Click);
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
            this.dashB.Click += new System.EventHandler(this.dashB_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppsDev.Properties.Resources.opacity20;
            this.pictureBox2.Location = new System.Drawing.Point(282, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // usernameData
            // 
            this.usernameData.AutoSize = true;
            this.usernameData.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.usernameData.ForeColor = System.Drawing.Color.White;
            this.usernameData.Location = new System.Drawing.Point(24, 428);
            this.usernameData.Name = "usernameData";
            this.usernameData.Size = new System.Drawing.Size(68, 13);
            this.usernameData.TabIndex = 6;
            this.usernameData.Text = "USERNAME";
            // 
            // MyBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernameData);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBaseForm";
            this.Text = "MyBaseForm";
            this.Load += new System.EventHandler(this.MyBaseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label logOut;
        private Label register;
        private Label search;
        private Label dashB;
        private Label records;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label usernameData;
    }
}