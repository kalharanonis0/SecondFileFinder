namespace SecondFileFinder
{
    partial class mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ProgressBar1 = new ReaLTaiizor.Controls.DungeonProgressBar();
            dgvResults = new DataGridView();
            colFileName = new DataGridViewTextBoxColumn();
            colFolder = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblStatus = new Label();
            btnSccan = new Button();
            btnSelect = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ProgressBar1);
            panel1.Controls.Add(dgvResults);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(btnSccan);
            panel1.Controls.Add(btnSelect);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(644, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ProgressBar1
            // 
            ProgressBar1.BackColor = Color.Transparent;
            ProgressBar1.BackColorA = Color.Black;
            ProgressBar1.BackColorB = Color.Black;
            ProgressBar1.BorderColor = Color.FromArgb(255, 128, 0);
            ProgressBar1.DrawHatch = true;
            ProgressBar1.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ProgressBar1.ForeColor = Color.DimGray;
            ProgressBar1.Location = new Point(12, 418);
            ProgressBar1.Maximum = 100;
            ProgressBar1.Minimum = 0;
            ProgressBar1.MinimumSize = new Size(58, 20);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.ProgressColorA = Color.FromArgb(214, 89, 37);
            ProgressBar1.ProgressColorB = Color.FromArgb(223, 118, 75);
            ProgressBar1.ProgressHatchColor = Color.FromArgb(255, 128, 0);
            ProgressBar1.ShowPercentage = true;
            ProgressBar1.Size = new Size(738, 20);
            ProgressBar1.TabIndex = 5;
            ProgressBar1.Text = "ProgressBar1";
            ProgressBar1.Value = 0;
            ProgressBar1.ValueAlignment = ReaLTaiizor.Controls.DungeonProgressBar.Alignment.Left;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.BackgroundColor = SystemColors.Desktop;
            dgvResults.BorderStyle = BorderStyle.None;
            dgvResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { colFileName, colFolder, colSize, colStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.GridColor = SystemColors.ActiveCaptionText;
            dgvResults.Location = new Point(12, 12);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvResults.Size = new Size(743, 339);
            dgvResults.TabIndex = 4;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // colFileName
            // 
            colFileName.HeaderText = "FileName";
            colFileName.Name = "colFileName";
            colFileName.Width = 200;
            // 
            // colFolder
            // 
            colFolder.HeaderText = "Folder";
            colFolder.Name = "colFolder";
            colFolder.Width = 200;
            // 
            // colSize
            // 
            colSize.HeaderText = "Size";
            colSize.Name = "colSize";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.Width = 150;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(12, 372);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // btnSccan
            // 
            btnSccan.Cursor = Cursors.Hand;
            btnSccan.FlatAppearance.BorderSize = 2;
            btnSccan.FlatStyle = FlatStyle.Flat;
            btnSccan.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnSccan.ForeColor = Color.FromArgb(255, 128, 0);
            btnSccan.Location = new Point(589, 372);
            btnSccan.Name = "btnSccan";
            btnSccan.Size = new Size(161, 36);
            btnSccan.TabIndex = 1;
            btnSccan.Text = "FindFile";
            btnSccan.UseVisualStyleBackColor = true;
            btnSccan.Click += btnSccan_Click;
            // 
            // btnSelect
            // 
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("SansSerif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnSelect.ForeColor = Color.FromArgb(255, 128, 0);
            btnSelect.Location = new Point(405, 372);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(161, 36);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(767, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "mainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecondFileFinder";
            TransparencyKey = Color.Fuchsia;
            FormClosed += Form2_FormClosed;
            Load += mainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSelect;
        private Button btnSccan;
        private Label lblStatus;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn colFileName;
        private DataGridViewTextBoxColumn colFolder;
        private DataGridViewTextBoxColumn colSize;
        private DataGridViewTextBoxColumn colStatus;
        private ReaLTaiizor.Controls.DungeonProgressBar ProgressBar1;
        private PictureBox pictureBox1;
    }
}
