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
			this._folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._txtClass = new System.Windows.Forms.Label();
			this._cmbClassList = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnLoad
			// 
			this._btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnLoad.Enabled = false;
			this._btnLoad.Location = new System.Drawing.Point(4, 128);
			this._btnLoad.Name = "_btnLoad";
			this._btnLoad.Size = new System.Drawing.Size(110, 23);
			this._btnLoad.TabIndex = 23;
			this._btnLoad.Text = "Загрузить проект";
			this._btnLoad.UseVisualStyleBackColor = true;
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnSave.Location = new System.Drawing.Point(3, 43);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(110, 39);
			this._btnSave.TabIndex = 22;
			this._btnSave.Text = "Генерация файла для обучения";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.OnSaveMarkup);
			// 
			// _btnOpen
			// 
			this._btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnOpen.Location = new System.Drawing.Point(2, 3);
			this._btnOpen.Name = "_btnOpen";
			this._btnOpen.Size = new System.Drawing.Size(110, 23);
			this._btnOpen.TabIndex = 21;
			this._btnOpen.Text = "Откыть папку";
			this._btnOpen.UseVisualStyleBackColor = true;
			this._btnOpen.Click += new System.EventHandler(this.OnOpenImgClick);
			// 
			// _btnBackImg
			// 
			this._btnBackImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnBackImg.Location = new System.Drawing.Point(2, 205);
			this._btnBackImg.Name = "_btnBackImg";
			this._btnBackImg.Size = new System.Drawing.Size(110, 23);
			this._btnBackImg.TabIndex = 20;
			this._btnBackImg.Text = "<<";
			this._btnBackImg.UseVisualStyleBackColor = true;
			this._btnBackImg.Click += new System.EventHandler(this.OnBackImageClick);
			// 
			// _btnNextImg
			// 
			this._btnNextImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnNextImg.Location = new System.Drawing.Point(2, 176);
			this._btnNextImg.Name = "_btnNextImg";
			this._btnNextImg.Size = new System.Drawing.Size(110, 23);
			this._btnNextImg.TabIndex = 19;
			this._btnNextImg.Text = ">>";
			this._btnNextImg.UseVisualStyleBackColor = true;
			this._btnNextImg.Click += new System.EventHandler(this.OnNextImageClick);
			// 
			// _txtClass
			// 
			this._txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._txtClass.AutoSize = true;
			this._txtClass.Location = new System.Drawing.Point(26, 259);
			this._txtClass.Name = "_txtClass";
			this._txtClass.Size = new System.Drawing.Size(65, 13);
			this._txtClass.TabIndex = 24;
			this._txtClass.Text = "Нет класса";
			// 
			// _cmbClassList
			// 
			this._cmbClassList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cmbClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbClassList.FormattingEnabled = true;
			this._cmbClassList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._cmbClassList.Items.AddRange(new object[] {
            "Car",
            "CarWithTrailer",
            "MiniTruck",
            "Truck",
            "BigTruck",
            "Hauler",
            "MiniBus",
            "Bus",
            "LongBus",
            "Bike",
            "SpecialCar",
            "EmergencyCar"});
			this._cmbClassList.Location = new System.Drawing.Point(3, 285);
			this._cmbClassList.Name = "_cmbClassList";
			this._cmbClassList.Size = new System.Drawing.Size(109, 21);
			this._cmbClassList.TabIndex = 25;
			this._cmbClassList.SelectedIndexChanged += new System.EventHandler(this.OnChangeIndexCmbClass);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(3, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 26;
			this.button1.Text = "Сохранить проект";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// SettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.button1);
			this.Controls.Add(this._cmbClassList);
			this.Controls.Add(this._txtClass);
			this.Controls.Add(this._btnLoad);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnOpen);
			this.Controls.Add(this._btnBackImg);
			this.Controls.Add(this._btnNextImg);
			this.Name = "SettingControl";
			this.Size = new System.Drawing.Size(115, 386);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnLoad;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Button _btnOpen;
		private System.Windows.Forms.Button _btnBackImg;
		private System.Windows.Forms.Button _btnNextImg;
		private System.Windows.Forms.FolderBrowserDialog _folderDialog;
		private System.Windows.Forms.Label _txtClass;
		private System.Windows.Forms.ComboBox _cmbClassList;
		private System.Windows.Forms.Button button1;
	}
}
