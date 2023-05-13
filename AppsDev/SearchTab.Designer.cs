namespace AppsDev
{
    partial class SearchTab
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
            tryAgain = new Button();
            resultNot = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            resultDisplay = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            refCode = new Label();
            displayName = new Label();
            displayForm1 = new DisplayForm();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tryAgain
            // 
            tryAgain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tryAgain.ForeColor = Color.White;
            tryAgain.Location = new Point(345, 334);
            tryAgain.Name = "tryAgain";
            tryAgain.Size = new Size(136, 46);
            tryAgain.TabIndex = 15;
            tryAgain.Text = "TRY AGAIN";
            tryAgain.UseVisualStyleBackColor = true;
            tryAgain.Click += tryAgain_Click;
            // 
            // resultNot
            // 
            resultNot.AutoSize = true;
            resultNot.Font = new Font("Segoe UI", 36F, FontStyle.Underline, GraphicsUnit.Point);
            resultNot.ForeColor = Color.White;
            resultNot.Location = new Point(219, 173);
            resultNot.Name = "resultNot";
            resultNot.Size = new Size(378, 65);
            resultNot.TabIndex = 14;
            resultNot.Text = "Result not found";
            // 
            // button1
            // 
            button1.Location = new Point(541, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 11);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 11;
            label1.Text = "Name / Reference Code: ";
            // 
            // resultDisplay
            // 
            resultDisplay.AutoSize = true;
            resultDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultDisplay.ForeColor = Color.White;
            resultDisplay.Location = new Point(200, 65);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.Size = new Size(71, 25);
            resultDisplay.TabIndex = 16;
            resultDisplay.Text = "Result: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.opacity20;
            pictureBox2.Location = new Point(268, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(refCode);
            panel1.Controls.Add(displayName);
            panel1.Location = new Point(200, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 29);
            panel1.TabIndex = 18;
            panel1.Click += panel1_Click;
            // 
            // refCode
            // 
            refCode.AutoSize = true;
            refCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            refCode.ForeColor = Color.White;
            refCode.Location = new Point(279, 4);
            refCode.Name = "refCode";
            refCode.Size = new Size(38, 25);
            refCode.TabIndex = 1;
            refCode.Text = "Ref";
            refCode.Click += displayName_Click;
            // 
            // displayName
            // 
            displayName.AutoSize = true;
            displayName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            displayName.ForeColor = Color.White;
            displayName.Location = new Point(0, 0);
            displayName.Name = "displayName";
            displayName.Size = new Size(65, 25);
            displayName.TabIndex = 0;
            displayName.Text = "NAME";
            displayName.Click += displayName_Click;
            // 
            // displayForm1
            // 
            displayForm1.BackColor = Color.FromArgb(16, 120, 116);
            displayForm1.Location = new Point(0, 0);
            displayForm1.Name = "displayForm1";
            displayForm1.Size = new Size(816, 390);
            displayForm1.TabIndex = 19;
            // 
            // SearchTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(displayForm1);
            Controls.Add(panel1);
            Controls.Add(resultNot);
            Controls.Add(resultDisplay);
            Controls.Add(tryAgain);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "SearchTab";
            Size = new Size(816, 390);
            Load += SearchTab_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tryAgain;
        private Label resultNot;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label resultDisplay;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label refCode;
        private Label displayName;
        private DisplayForm displayForm1;
    }
}
