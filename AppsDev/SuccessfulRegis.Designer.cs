namespace AppsDev
{
    partial class SuccessfulRegis
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            displaySuccess = new Label();
            continueBut = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(268, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(223, 68);
            label1.Name = "label1";
            label1.Size = new Size(399, 47);
            label1.TabIndex = 20;
            label1.Text = "Successfully Registered!";
            // 
            // displaySuccess
            // 
            displaySuccess.AutoSize = true;
            displaySuccess.BackColor = Color.Transparent;
            displaySuccess.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            displaySuccess.ForeColor = Color.White;
            displaySuccess.Location = new Point(292, 0);
            displaySuccess.Name = "displaySuccess";
            displaySuccess.Size = new Size(94, 25);
            displaySuccess.TabIndex = 21;
            displaySuccess.Text = "INFO1234";
            // 
            // continueBut
            // 
            continueBut.BackColor = Color.Transparent;
            continueBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            continueBut.ForeColor = Color.White;
            continueBut.Location = new Point(351, 334);
            continueBut.Name = "continueBut";
            continueBut.Size = new Size(120, 31);
            continueBut.TabIndex = 80;
            continueBut.Text = "CONTINUE";
            continueBut.UseVisualStyleBackColor = false;
            continueBut.Click += continueBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 81;
            label2.Text = "Reference Code: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(displaySuccess);
            panel1.Location = new Point(220, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 32);
            panel1.TabIndex = 82;
            // 
            // SuccessfulRegis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(continueBut);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "SuccessfulRegis";
            Size = new Size(816, 390);
            Load += SuccessfulRegis_Load;
            VisibleChanged += SuccessfulRegis_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label displaySuccess;
        private Button continueBut;
        private Label label2;
        private Panel panel1;
    }
}
