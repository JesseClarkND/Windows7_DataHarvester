namespace Windows7_DataHarvester
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
            this._btnStart = new System.Windows.Forms.Button();
            this._rtbLogs = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this._btnBrowse = new System.Windows.Forms.Button();
            this._txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(652, 12);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(75, 49);
            this._btnStart.TabIndex = 0;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _rtbLogs
            // 
            this._rtbLogs.Location = new System.Drawing.Point(13, 71);
            this._rtbLogs.Name = "_rtbLogs";
            this._rtbLogs.Size = new System.Drawing.Size(714, 209);
            this._rtbLogs.TabIndex = 1;
            this._rtbLogs.Text = "";
            // 
            // _btnBrowse
            // 
            this._btnBrowse.Location = new System.Drawing.Point(13, 12);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(75, 23);
            this._btnBrowse.TabIndex = 2;
            this._btnBrowse.Text = "Browse";
            this._btnBrowse.UseVisualStyleBackColor = true;
            this._btnBrowse.Click += new System.EventHandler(this._btnBrowse_Click);
            // 
            // _txtPath
            // 
            this._txtPath.Location = new System.Drawing.Point(13, 41);
            this._txtPath.Name = "_txtPath";
            this._txtPath.Size = new System.Drawing.Size(333, 20);
            this._txtPath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 292);
            this.Controls.Add(this._txtPath);
            this.Controls.Add(this._btnBrowse);
            this.Controls.Add(this._rtbLogs);
            this.Controls.Add(this._btnStart);
            this.Name = "Form1";
            this.Text = "DataHarvester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.RichTextBox _rtbLogs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button _btnBrowse;
        private System.Windows.Forms.TextBox _txtPath;
    }
}

