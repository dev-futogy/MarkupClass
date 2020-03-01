namespace MarkupClass
{
	partial class SettingControl
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
			this._btnLoad = new System.Windows.Forms.Button();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnOpen = new System.Windows.Forms.Button();
			this._btnBackImg = new System.Windows.Forms.Button();
			this._btnNextImg = new System.Windows.Forms.Button();
			this._btnJilet = new System.Windows.Forms.Button();
			this._btnCaska = new System.Windows.Forms.Button();
			this._btnSIZ = new System.Windows.Forms.Button();
			this._btnNoSIZ = new System.Windows.Forms.Button();
			this._folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._txtClass = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _btnLoad
			// 
			this._btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnLoad.Enabled = false;
			this._btnLoad.Location = new System.Drawing.Point(3, 62);
			this._btnLoad.Name = "_btnLoad";
			this._btnLoad.Size = new System.Drawing.Size(110, 23);
			this._btnLoad.TabIndex = 23;
			this._btnLoad.Text = "Загрузить";
			this._btnLoad.UseVisualStyleBackColor = true;
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnSave.Location = new System.Drawing.Point(3, 32);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(110, 23);
			this._btnSave.TabIndex = 22;
			this._btnSave.Text = "Сохранить";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.OnSaveMarkup);
			// 
			// _btnOpen
			// 
			this._btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnOpen.Location = new System.Drawing.Point(3, 3);
			this._btnOpen.Name = "_btnOpen";
			this._btnOpen.Size = new System.Drawing.Size(110, 23);
			this._btnOpen.TabIndex = 21;
			this._btnOpen.Text = "Откыть папку";
			this._btnOpen.UseVisualStyleBackColor = true;
			this._btnOpen.Click += new System.EventHandler(this.OnOpenImgClick);
			// 
			// _btnBackImg
			// 
			this._btnBackImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnBackImg.Location = new System.Drawing.Point(3, 154);
			this._btnBackImg.Name = "_btnBackImg";
			this._btnBackImg.Size = new System.Drawing.Size(110, 23);
			this._btnBackImg.TabIndex = 20;
			this._btnBackImg.Text = "<<";
			this._btnBackImg.UseVisualStyleBackColor = true;
			this._btnBackImg.Click += new System.EventHandler(this.OnBackImageClick);
			// 
			// _btnNextImg
			// 
			this._btnNextImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnNextImg.Location = new System.Drawing.Point(3, 125);
			this._btnNextImg.Name = "_btnNextImg";
			this._btnNextImg.Size = new System.Drawing.Size(110, 23);
			this._btnNextImg.TabIndex = 19;
			this._btnNextImg.Text = ">>";
			this._btnNextImg.UseVisualStyleBackColor = true;
			this._btnNextImg.Click += new System.EventHandler(this.OnNextImageClick);
			// 
			// _btnJilet
			// 
			this._btnJilet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnJilet.Location = new System.Drawing.Point(2, 307);
			this._btnJilet.Name = "_btnJilet";
			this._btnJilet.Size = new System.Drawing.Size(110, 23);
			this._btnJilet.TabIndex = 15;
			this._btnJilet.Text = "Есть жилет";
			this._btnJilet.UseVisualStyleBackColor = true;
			this._btnJilet.Click += new System.EventHandler(this.OnJiletClick);
			// 
			// _btnCaska
			// 
			this._btnCaska.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnCaska.Location = new System.Drawing.Point(2, 278);
			this._btnCaska.Name = "_btnCaska";
			this._btnCaska.Size = new System.Drawing.Size(110, 23);
			this._btnCaska.TabIndex = 16;
			this._btnCaska.Text = "Есть каска";
			this._btnCaska.UseVisualStyleBackColor = true;
			this._btnCaska.Click += new System.EventHandler(this.OnCaskaClick);
			// 
			// _btnSIZ
			// 
			this._btnSIZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSIZ.Location = new System.Drawing.Point(2, 336);
			this._btnSIZ.Name = "_btnSIZ";
			this._btnSIZ.Size = new System.Drawing.Size(110, 23);
			this._btnSIZ.TabIndex = 17;
			this._btnSIZ.Text = "Все есть";
			this._btnSIZ.UseVisualStyleBackColor = true;
			this._btnSIZ.Click += new System.EventHandler(this.OnAllSizClick);
			// 
			// _btnNoSIZ
			// 
			this._btnNoSIZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnNoSIZ.Location = new System.Drawing.Point(2, 249);
			this._btnNoSIZ.Name = "_btnNoSIZ";
			this._btnNoSIZ.Size = new System.Drawing.Size(110, 23);
			this._btnNoSIZ.TabIndex = 18;
			this._btnNoSIZ.Text = "Без СИЗ";
			this._btnNoSIZ.UseVisualStyleBackColor = true;
			this._btnNoSIZ.Click += new System.EventHandler(this.OnNoSizClick);
			// 
			// _txtClass
			// 
			this._txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._txtClass.AutoSize = true;
			this._txtClass.Location = new System.Drawing.Point(22, 224);
			this._txtClass.Name = "_txtClass";
			this._txtClass.Size = new System.Drawing.Size(65, 13);
			this._txtClass.TabIndex = 24;
			this._txtClass.Text = "Нет класса";
			// 
			// SettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this._txtClass);
			this.Controls.Add(this._btnLoad);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnOpen);
			this.Controls.Add(this._btnBackImg);
			this.Controls.Add(this._btnNextImg);
			this.Controls.Add(this._btnJilet);
			this.Controls.Add(this._btnCaska);
			this.Controls.Add(this._btnSIZ);
			this.Controls.Add(this._btnNoSIZ);
			this.Name = "SettingControl";
			this.Size = new System.Drawing.Size(115, 390);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnLoad;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Button _btnOpen;
		private System.Windows.Forms.Button _btnBackImg;
		private System.Windows.Forms.Button _btnNextImg;
		private System.Windows.Forms.Button _btnJilet;
		private System.Windows.Forms.Button _btnCaska;
		private System.Windows.Forms.Button _btnSIZ;
		private System.Windows.Forms.Button _btnNoSIZ;
		private System.Windows.Forms.FolderBrowserDialog _folderDialog;
		private System.Windows.Forms.Label _txtClass;
	}
}
