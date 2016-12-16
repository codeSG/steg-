namespace steg__
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
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.checkBoxKey = new System.Windows.Forms.CheckBox();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.enterMessageBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDecode
            // 
            this.buttonDecode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDecode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDecode.Location = new System.Drawing.Point(216, 287);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 2;
            this.buttonDecode.Text = "DECODE";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEncode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEncode.Location = new System.Drawing.Point(88, 287);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "ENCODE";
            this.buttonEncode.UseVisualStyleBackColor = false;
            this.buttonEncode.SizeChanged += new System.EventHandler(this.checkBoxKey_CheckedChanged);
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBox.Location = new System.Drawing.Point(206, 223);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(111, 20);
            this.KeyBox.TabIndex = 5;
            this.KeyBox.UseSystemPasswordChar = true;
            // 
            // FileBox
            // 
            this.FileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBox.Location = new System.Drawing.Point(206, 182);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(111, 20);
            this.FileBox.TabIndex = 6;
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKey.AutoSize = true;
            this.labelKey.Image = global::steg__.Properties.Resources.key_icon__1_;
            this.labelKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey.Location = new System.Drawing.Point(79, 223);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(80, 13);
            this.labelKey.TabIndex = 9;
            this.labelKey.Text = "Enter Key         ";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Image = global::steg__.Properties.Resources.new_message_icon;
            this.labelMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMessage.Location = new System.Drawing.Point(79, 261);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(104, 13);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Enter message         ";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(100, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 171);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Image = global::steg__.Properties.Resources.Open_file_icon;
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFile.Location = new System.Drawing.Point(82, 182);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(91, 30);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // checkBoxKey
            // 
            this.checkBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKey.AutoSize = true;
            this.checkBoxKey.Location = new System.Drawing.Point(337, 223);
            this.checkBoxKey.Name = "checkBoxKey";
            this.checkBoxKey.Size = new System.Drawing.Size(53, 17);
            this.checkBoxKey.TabIndex = 10;
            this.checkBoxKey.Text = "Show";
            this.checkBoxKey.UseVisualStyleBackColor = true;
            this.checkBoxKey.CheckedChanged += new System.EventHandler(this.checkBoxKey_CheckedChanged);
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Location = new System.Drawing.Point(337, 263);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(53, 17);
            this.checkBoxMessage.TabIndex = 11;
            this.checkBoxMessage.Text = "Show";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            this.checkBoxMessage.CheckedChanged += new System.EventHandler(this.checkBoxMessage_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(94, 313);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterMessageBox
            // 
            this.enterMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterMessageBox.Location = new System.Drawing.Point(206, 262);
            this.enterMessageBox.Name = "enterMessageBox";
            this.enterMessageBox.Size = new System.Drawing.Size(111, 20);
            this.enterMessageBox.TabIndex = 13;
            this.enterMessageBox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 328);
            this.Controls.Add(this.enterMessageBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.checkBoxMessage);
            this.Controls.Add(this.checkBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(455, 367);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.CheckBox checkBoxKey;
        private System.Windows.Forms.CheckBox checkBoxMessage;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox enterMessageBox;
    }
}

