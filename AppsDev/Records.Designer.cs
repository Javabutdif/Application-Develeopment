namespace AppsDev
{
    partial class Records
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
            panel1 = new Panel();
            listBox2 = new ListBox();
            clearAll = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
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
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(clearAll);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 327);
            panel1.TabIndex = 19;
            // 
            // listBox2
            // 
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox2.ForeColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(507, 49);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(229, 250);
            listBox2.TabIndex = 4;
            // 
            // clearAll
            // 
            clearAll.Location = new Point(670, 18);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(75, 23);
            clearAll.TabIndex = 3;
            clearAll.Text = "Clear";
            clearAll.UseVisualStyleBackColor = true;
            clearAll.Click += clearAll_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ColumnWidth = 1;
            listBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(3, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 250);
            listBox1.Sorted = true;
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.VisibleChanged += listView1_VisibleChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 1;
            label1.Text = "REGISTERED CITIZENS";
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Records";
            Size = new Size(816, 390);
            Load += Records_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private Button clearAll;
        private ListBox listBox2;
    }
}
