namespace Voice_Recognition_and_Command
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPresentation = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonHowTo = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century", 10.75F);
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(230, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Application was developed by\r\nImperium, exclusively for Teachers\'\r\nand Stude" +
    "nts\' Presentations \r\nin BCSHS-SAC\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPresentation
            // 
            this.buttonPresentation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPresentation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPresentation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPresentation.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresentation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPresentation.Location = new System.Drawing.Point(13, 83);
            this.buttonPresentation.Name = "buttonPresentation";
            this.buttonPresentation.Size = new System.Drawing.Size(110, 26);
            this.buttonPresentation.TabIndex = 2;
            this.buttonPresentation.Text = "Presentation";
            this.buttonPresentation.UseVisualStyleBackColor = false;
            this.buttonPresentation.Click += new System.EventHandler(this.buttonPresentation_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVideo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideo.Location = new System.Drawing.Point(137, 83);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(110, 26);
            this.buttonVideo.TabIndex = 3;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonHowTo
            // 
            this.buttonHowTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHowTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHowTo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHowTo.Location = new System.Drawing.Point(75, 114);
            this.buttonHowTo.Name = "buttonHowTo";
            this.buttonHowTo.Size = new System.Drawing.Size(110, 24);
            this.buttonHowTo.TabIndex = 1;
            this.buttonHowTo.Text = "How to Use";
            this.buttonHowTo.UseVisualStyleBackColor = false;
            this.buttonHowTo.Click += new System.EventHandler(this.buttonHowTo_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.buttonHowTo);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.buttonPresentation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPresentation;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonHowTo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

