namespace AppsDev
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            signUp = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            backBut = new Button();
            label1 = new Label();
            userInput = new TextBox();
            newPass = new TextBox();
            label2 = new Label();
            confirmPass = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // signUp
            // 
            signUp.BackColor = Color.Transparent;
            signUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUp.ForeColor = Color.White;
            signUp.Location = new Point(662, 407);
            signUp.Name = "signUp";
            signUp.Size = new Size(120, 31);
            signUp.TabIndex = 24;
            signUp.Text = "SIGN UP ->";
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(282, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // backBut
            // 
            backBut.BackColor = Color.Transparent;
            backBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backBut.ForeColor = Color.White;
            backBut.Location = new Point(19, 407);
            backBut.Name = "backBut";
            backBut.Size = new Size(120, 31);
            backBut.TabIndex = 21;
            backBut.Text = "BACK";
            backBut.UseVisualStyleBackColor = false;
            backBut.Click += backBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 76);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 25;
            label1.Text = "USERNAME";
            // 
            // userInput
            // 
            userInput.Location = new Point(299, 94);
            userInput.Name = "userInput";
            userInput.Size = new Size(237, 23);
            userInput.TabIndex = 26;
            userInput.TextAlign = HorizontalAlignment.Center;
            userInput.TextChanged += userInput_TextChanged;
            // 
            // newPass
            // 
            newPass.Location = new Point(299, 177);
            newPass.Name = "newPass";
            newPass.Size = new Size(237, 23);
            newPass.TabIndex = 28;
            newPass.TextAlign = HorizontalAlignment.Center;
            newPass.TextChanged += newPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(367, 159);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 27;
            label2.Text = "NEW PASSWORD";
            // 
            // confirmPass
            // 
            confirmPass.Location = new Point(299, 236);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(237, 23);
            confirmPass.TabIndex = 30;
            confirmPass.TextAlign = HorizontalAlignment.Center;
            confirmPass.TextChanged += confirmPass_TextChanged;
            confirmPass.Validating += confirmPass_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(355, 218);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 29;
            label3.Text = "CONFIRM PASSWORD";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmPass);
            Controls.Add(label3);
            Controls.Add(newPass);
            Controls.Add(label2);
            Controls.Add(userInput);
            Controls.Add(label1);
            Controls.Add(signUp);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(backBut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Registration";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button backBut;
        private Label label1;
        private TextBox userInput;
        private TextBox newPass;
        private Label label2;
        private TextBox confirmPass;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}