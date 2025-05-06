namespace BeePhotoConverter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkAlternatePath = new System.Windows.Forms.CheckBox();
            this.btnAlternatePath = new System.Windows.Forms.Button();
            this.txtAlternatePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pctPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChooseSource = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lstSource
            // 
            this.lstSource.Enabled = false;
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Items.AddRange(new object[] {
            "Please select files....."});
            this.lstSource.Location = new System.Drawing.Point(12, 36);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(322, 550);
            this.lstSource.TabIndex = 1;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(336, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 578);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.chkAlternatePath);
            this.tabPage1.Controls.Add(this.btnAlternatePath);
            this.tabPage1.Controls.Add(this.txtAlternatePath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnConvert);
            this.tabPage1.Controls.Add(this.pctPreview);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HEIF to JPEG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 521);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(495, 23);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // chkAlternatePath
            // 
            this.chkAlternatePath.AutoSize = true;
            this.chkAlternatePath.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlternatePath.Location = new System.Drawing.Point(7, 473);
            this.chkAlternatePath.Name = "chkAlternatePath";
            this.chkAlternatePath.Size = new System.Drawing.Size(121, 17);
            this.chkAlternatePath.TabIndex = 13;
            this.chkAlternatePath.Text = "Alternate Save Path";
            this.chkAlternatePath.UseVisualStyleBackColor = true;
            this.chkAlternatePath.CheckedChanged += new System.EventHandler(this.chkAlternatePath_CheckedChanged);
            // 
            // btnAlternatePath
            // 
            this.btnAlternatePath.Enabled = false;
            this.btnAlternatePath.Location = new System.Drawing.Point(414, 473);
            this.btnAlternatePath.Name = "btnAlternatePath";
            this.btnAlternatePath.Size = new System.Drawing.Size(34, 26);
            this.btnAlternatePath.TabIndex = 12;
            this.btnAlternatePath.Text = "...";
            this.btnAlternatePath.UseVisualStyleBackColor = true;
            this.btnAlternatePath.Click += new System.EventHandler(this.btnAlternatePath_Click);
            // 
            // txtAlternatePath
            // 
            this.txtAlternatePath.Enabled = false;
            this.txtAlternatePath.Location = new System.Drawing.Point(134, 474);
            this.txtAlternatePath.Name = "txtAlternatePath";
            this.txtAlternatePath.Size = new System.Drawing.Size(273, 20);
            this.txtAlternatePath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "keeping any metadata";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(635, 460);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 55);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pctPreview
            // 
            this.pctPreview.BackColor = System.Drawing.Color.Wheat;
            this.pctPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctPreview.Location = new System.Drawing.Point(7, 84);
            this.pctPreview.Name = "pctPreview";
            this.pctPreview.Size = new System.Drawing.Size(441, 369);
            this.pctPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPreview.TabIndex = 7;
            this.pctPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "This will convert the chosen files from HEIF to JPEG format";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Items.AddRange(new object[] {
            "Results will be shown here"});
            this.lstResults.Location = new System.Drawing.Point(454, 84);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(322, 368);
            this.lstResults.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1041, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.Location = new System.Drawing.Point(12, 592);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(75, 31);
            this.btnChooseSource.TabIndex = 4;
            this.btnChooseSource.Text = "Select File(s)";
            this.btnChooseSource.UseVisualStyleBackColor = true;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(122, 592);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(96, 29);
            this.btnFolder.TabIndex = 6;
            this.btnFolder.Text = "Select Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 635);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChooseSource);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bee Photo Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChooseSource;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox pctPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkAlternatePath;
        private System.Windows.Forms.Button btnAlternatePath;
        private System.Windows.Forms.TextBox txtAlternatePath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnFolder;
    }
}

