namespace SecondFileFinder.Forms
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            passTextBox = new ReaLTaiizor.Controls.DreamTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // passTextBox
            // 
            passTextBox.BackColor = Color.Black;
            passTextBox.BorderStyle = BorderStyle.FixedSingle;
            passTextBox.ColorA = Color.FromArgb(31, 31, 31);
            passTextBox.ColorB = Color.FromArgb(41, 41, 41);
            passTextBox.ColorC = Color.FromArgb(51, 51, 51);
            passTextBox.ColorD = Color.FromArgb(0, 0, 0, 0);
            passTextBox.ColorE = Color.FromArgb(25, 255, 255, 255);
            passTextBox.ColorF = Color.Black;
            passTextBox.ForeColor = Color.FromArgb(255, 128, 0);
            passTextBox.Location = new Point(73, 256);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(194, 23);
            passTextBox.TabIndex = 2;
            passTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(73, 319);
            button1.Name = "button1";
            button1.Size = new Size(194, 37);
            button1.TabIndex = 4;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Romantic", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label1.Location = new Point(132, 375);
            label1.Name = "label1";
            label1.Size = new Size(68, 12);
            label1.TabIndex = 5;
            label1.Text = "Enter the PIN";
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(349, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(passTextBox);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "loginPage";
            Text = "SecondFileFinder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DreamTextBox passTextBox;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
    }
}