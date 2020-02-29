namespace MarkupClass
{
	partial class VideoPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._framePanel = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._framePanel)).BeginInit();
			this.SuspendLayout();
			// 
			// _framePanel
			// 
			this._framePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._framePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this._framePanel.Location = new System.Drawing.Point(0, 0);
			this._framePanel.Name = "_framePanel";
			this._framePanel.Size = new System.Drawing.Size(504, 376);
			this._framePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._framePanel.TabIndex = 0;
			this._framePanel.TabStop = false;
			// 
			// VideoPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._framePanel);
			this.Name = "VideoPanel";
			this.Size = new System.Drawing.Size(504, 376);
			((System.ComponentModel.ISupportInitialize)(this._framePanel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _framePanel;
	}
}
