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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            resultDisplay.Location = new Point(200, 11);
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
            // SearchTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
