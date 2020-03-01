namespace MarkupClass
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlFrame = new System.Windows.Forms.Panel();
			this._pnlSetting = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlFrame
			// 
			this._pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlFrame.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this._pnlFrame.Location = new System.Drawing.Point(1, 0);
			this._pnlFrame.Name = "_pnlFrame";
			this._pnlFrame.Size = new System.Drawing.Size(384, 362);
			this._pnlFrame.TabIndex = 0;
			// 
			// _pnlSetting
			// 
			this._pnlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSetting.Location = new System.Drawing.Point(383, 0);
			this._pnlSetting.Name = "_pnlSetting";
			this._pnlSetting.Size = new System.Drawing.Size(114, 470);
			this._pnlSetting.TabIndex = 1;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(1, 361);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(384, 107);
			this._pnlLog.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 470);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlSetting);
			this.Controls.Add(this._pnlFrame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "MarkupClass";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlFrame;
		private System.Windows.Forms.Panel _pnlSetting;
		private System.Windows.Forms.Panel _pnlLog;
	}
}

