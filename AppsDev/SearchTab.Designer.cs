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
            this.tryAgain = new System.Windows.Forms.Button();
            this.resultNot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultDisplay = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tryAgain.ForeColor = System.Drawing.Color.White;
            this.tryAgain.Location = new System.Drawing.Point(345, 334);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(136, 46);
            this.tryAgain.TabIndex = 15;
            this.tryAgain.Text = "TRY AGAIN";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // resultNot
            // 
            this.resultNot.AutoSize = true;
            this.resultNot.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.resultNot.ForeColor = System.Drawing.Color.White;
            this.resultNot.Location = new System.Drawing.Point(219, 173);
            this.resultNot.Name = "resultNot";
            this.resultNot.Size = new System.Drawing.Size(378, 65);
            this.resultNot.TabIndex = 14;
            this.resultNot.Text = "Result not found";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name / Reference Code: ";
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultDisplay.ForeColor = System.Drawing.Color.White;
            this.resultDisplay.Location = new System.Drawing.Point(200, 65);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(71, 25);
            this.resultDisplay.TabIndex = 16;
            this.resultDisplay.Text = "Result: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppsDev.Properties.Resources.opacity20;
            this.pictureBox2.Location = new System.Drawing.Point(268, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // SearchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultNot);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SearchTab";
            this.Size = new System.Drawing.Size(816, 390);
            this.Load += new System.EventHandler(this.SearchTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
