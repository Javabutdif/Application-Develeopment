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
            panel2 = new Panel();
            logOut = new Label();
            register = new Label();
            search = new Label();
            dashB = new Label();
            records = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            usernameData = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 47);
            panel2.TabIndex = 1;
            // 
            // logOut
            // 
            logOut.AutoSize = true;
            logOut.BorderStyle = BorderStyle.FixedSingle;
            logOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOut.ForeColor = Color.White;
            logOut.Location = new Point(711, 10);
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
            register.Location = new Point(543, 10);
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
            search.Location = new Point(443, 10);
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
            dashB.Location = new Point(157, 10);
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
            records.Location = new Point(289, 10);
            records.Name = "records";
            records.Size = new Size(78, 25);
            records.TabIndex = 1;
            records.Text = "Records";
            records.MouseLeave += records_MouseLeave;
            records.MouseHover += records_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lg;
            pictureBox1.Location = new Point(373, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(282, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // usernameData
            // 
            usernameData.AutoSize = true;
            usernameData.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            usernameData.ForeColor = Color.White;
            usernameData.Location = new Point(24, 428);
            usernameData.Name = "usernameData";
            usernameData.Size = new Size(68, 13);
            usernameData.TabIndex = 6;
            usernameData.Text = "USERNAME";
            usernameData.Click += usernameData_Click;
            // 
            // MyBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usernameData);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyBaseForm";
            Text = "MyBaseForm";
            Load += MyBaseForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Label usernameData;
    }
}