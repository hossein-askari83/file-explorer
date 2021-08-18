namespace show_directories
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
            this.comboBoxDirectory = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adressBar = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showTxtFile = new System.Windows.Forms.TextBox();
            this.closeMedia = new System.Windows.Forms.Button();
            this.closePic = new System.Windows.Forms.Button();
            this.closeTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDirectory
            // 
            this.comboBoxDirectory.FormattingEnabled = true;
            this.comboBoxDirectory.Location = new System.Drawing.Point(124, 13);
            this.comboBoxDirectory.Name = "comboBoxDirectory";
            this.comboBoxDirectory.Size = new System.Drawing.Size(76, 24);
            this.comboBoxDirectory.TabIndex = 0;
            this.comboBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirectory_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(80, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 388);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // adressBar
            // 
            this.adressBar.Location = new System.Drawing.Point(206, 13);
            this.adressBar.Multiline = true;
            this.adressBar.Name = "adressBar";
            this.adressBar.ReadOnly = true;
            this.adressBar.Size = new System.Drawing.Size(250, 24);
            this.adressBar.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(80, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(38, 24);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "<---";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(80, 458);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 40);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(224, 458);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(92, 40);
            this.moveBtn.TabIndex = 5;
            this.moveBtn.Text = "MOVE";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(364, 458);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(92, 40);
            this.newBtn.TabIndex = 6;
            this.newBtn.Text = "NEW";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(364, 11);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(230, 126);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // showTxtFile
            // 
            this.showTxtFile.Location = new System.Drawing.Point(486, 340);
            this.showTxtFile.Multiline = true;
            this.showTxtFile.Name = "showTxtFile";
            this.showTxtFile.ReadOnly = true;
            this.showTxtFile.Size = new System.Drawing.Size(306, 158);
            this.showTxtFile.TabIndex = 9;
            this.showTxtFile.Visible = false;
            // 
            // closeMedia
            // 
            this.closeMedia.BackColor = System.Drawing.Color.LightCoral;
            this.closeMedia.Location = new System.Drawing.Point(798, 11);
            this.closeMedia.Name = "closeMedia";
            this.closeMedia.Size = new System.Drawing.Size(32, 26);
            this.closeMedia.TabIndex = 10;
            this.closeMedia.Text = "×";
            this.closeMedia.UseVisualStyleBackColor = false;
            this.closeMedia.Visible = false;
            this.closeMedia.Click += new System.EventHandler(this.closeMedia_Click);
            // 
            // closePic
            // 
            this.closePic.BackColor = System.Drawing.Color.LightCoral;
            this.closePic.Location = new System.Drawing.Point(798, 176);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(32, 26);
            this.closePic.TabIndex = 11;
            this.closePic.Text = "×";
            this.closePic.UseVisualStyleBackColor = false;
            this.closePic.Visible = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // closeTxt
            // 
            this.closeTxt.BackColor = System.Drawing.Color.LightCoral;
            this.closeTxt.Location = new System.Drawing.Point(798, 338);
            this.closeTxt.Name = "closeTxt";
            this.closeTxt.Size = new System.Drawing.Size(32, 26);
            this.closeTxt.TabIndex = 12;
            this.closeTxt.Text = "×";
            this.closeTxt.UseVisualStyleBackColor = false;
            this.closeTxt.Visible = false;
            this.closeTxt.Click += new System.EventHandler(this.closeTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 604);
            this.Controls.Add(this.closeTxt);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.closeMedia);
            this.Controls.Add(this.showTxtFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.adressBar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDirectory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox adressBar;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox showTxtFile;
        private System.Windows.Forms.Button closeMedia;
        private System.Windows.Forms.Button closePic;
        private System.Windows.Forms.Button closeTxt;
    }
}

