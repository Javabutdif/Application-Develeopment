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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            displaySuccess.ForeColor = Color.White;
            displaySuccess.Location = new Point(351, 149);
            displaySuccess.Name = "displaySuccess";
            displaySuccess.Size = new Size(140, 15);
            displaySuccess.TabIndex = 21;
            displaySuccess.Text = "thisDisplayRegisteredInfo";
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
            // SuccessfulRegis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(continueBut);
            Controls.Add(displaySuccess);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "SuccessfulRegis";
            Size = new Size(816, 390);
            Load += SuccessfulRegis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label displaySuccess;
        private Button continueBut;
    }
}
