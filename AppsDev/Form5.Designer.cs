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
            panel1 = new Panel();
            logOut = new Label();
            register = new Label();
            search = new Label();
            dashB = new Label();
            records = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(logOut);
            panel1.Controls.Add(register);
            panel1.Controls.Add(search);
            panel1.Controls.Add(dashB);
            panel1.Controls.Add(records);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 47);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.Location = new Point(13, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 352);
            panel2.TabIndex = 1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Registration";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
    }
}