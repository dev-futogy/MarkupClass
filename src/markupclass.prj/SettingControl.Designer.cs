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
			this._btnLoadProject = new System.Windows.Forms.Button();
			this._btnCreateMarkup = new System.Windows.Forms.Button();
			this._btnNewProject = new System.Windows.Forms.Button();
			this._btnBackImg = new System.Windows.Forms.Button();
			this._btnNextImg = new System.Windows.Forms.Button();
			this._folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._txtClass = new System.Windows.Forms.Label();
			this._cmbClassList = new System.Windows.Forms.ComboBox();
			this._btnSaveProject = new System.Windows.Forms.Button();
			this._opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._btnHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnLoadProject
			// 
			this._btnLoadProject.Location = new System.Drawing.Point(2, 32);
			this._btnLoadProject.Name = "_btnLoadProject";
			this._btnLoadProject.Size = new System.Drawing.Size(110, 23);
			this._btnLoadProject.TabIndex = 23;
			this._btnLoadProject.Text = "Загрузить проект";
			this._btnLoadProject.UseVisualStyleBackColor = true;
			this._btnLoadProject.Click += new System.EventHandler(this.OnOpenLoadProject);
			// 
			// _btnCreateMarkup
			// 
			this._btnCreateMarkup.Enabled = false;
			this._btnCreateMarkup.Location = new System.Drawing.Point(2, 329);
			this._btnCreateMarkup.Name = "_btnCreateMarkup";
			this._btnCreateMarkup.Size = new System.Drawing.Size(110, 39);
			this._btnCreateMarkup.TabIndex = 22;
			this._btnCreateMarkup.Text = "Генерация файла для обучения";
			this._btnCreateMarkup.UseVisualStyleBackColor = true;
			this._btnCreateMarkup.Click += new System.EventHandler(this.OnSaveMarkup);
			// 
			// _btnNewProject
			// 
			this._btnNewProject.Location = new System.Drawing.Point(2, 3);
			this._btnNewProject.Name = "_btnNewProject";
			this._btnNewProject.Size = new System.Drawing.Size(110, 23);
			this._btnNewProject.TabIndex = 21;
			this._btnNewProject.Text = "Новый проект";
			this._btnNewProject.UseVisualStyleBackColor = true;
			this._btnNewProject.Click += new System.EventHandler(this.OnOpenImgClick);
			// 
			// _btnBackImg
			// 
			this._btnBackImg.Enabled = false;
			this._btnBackImg.Location = new System.Drawing.Point(2, 141);
			this._btnBackImg.Name = "_btnBackImg";
			this._btnBackImg.Size = new System.Drawing.Size(110, 23);
			this._btnBackImg.TabIndex = 20;
			this._btnBackImg.Text = "<<";
			this._btnBackImg.UseVisualStyleBackColor = true;
			this._btnBackImg.Click += new System.EventHandler(this.OnBackImageClick);
			// 
			// _btnNextImg
			// 
			this._btnNextImg.Enabled = false;
			this._btnNextImg.Location = new System.Drawing.Point(2, 112);
			this._btnNextImg.Name = "_btnNextImg";
			this._btnNextImg.Size = new System.Drawing.Size(110, 23);
			this._btnNextImg.TabIndex = 19;
			this._btnNextImg.Text = ">>";
			this._btnNextImg.UseVisualStyleBackColor = true;
			this._btnNextImg.Click += new System.EventHandler(this.OnNextImageClick);
			// 
			// _txtClass
			// 
			this._txtClass.AutoSize = true;
			this._txtClass.Enabled = false;
			this._txtClass.Location = new System.Drawing.Point(26, 222);
			this._txtClass.Name = "_txtClass";
			this._txtClass.Size = new System.Drawing.Size(65, 13);
			this._txtClass.TabIndex = 24;
			this._txtClass.Text = "Нет класса";
			this._txtClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _cmbClassList
			// 
			this._cmbClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbClassList.Enabled = false;
			this._cmbClassList.FormattingEnabled = true;
			this._cmbClassList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this._cmbClassList.Items.AddRange(new object[] {
            "All",
            "Helmet",
            "Vest",
            "Nothing"});
			this._cmbClassList.Location = new System.Drawing.Point(3, 248);
			this._cmbClassList.Name = "_cmbClassList";
			this._cmbClassList.Size = new System.Drawing.Size(109, 21);
			this._cmbClassList.TabIndex = 25;
			this._cmbClassList.SelectedIndexChanged += new System.EventHandler(this.OnChangeIndexCmbClass);
			// 
			// _btnSaveProject
			// 
			this._btnSaveProject.Enabled = false;
			this._btnSaveProject.Location = new System.Drawing.Point(2, 61);
			this._btnSaveProject.Name = "_btnSaveProject";
			this._btnSaveProject.Size = new System.Drawing.Size(110, 23);
			this._btnSaveProject.TabIndex = 26;
			this._btnSaveProject.Text = "Сохранить проект";
			this._btnSaveProject.UseVisualStyleBackColor = true;
			this._btnSaveProject.Click += new System.EventHandler(this.OnSaveProject);
			// 
			// _opnFileDialog
			// 
			this._opnFileDialog.FileName = "project.xml";
			this._opnFileDialog.Filter = "XML|*.xml";
			this._opnFileDialog.Title = "Открыть файл проекта";
			this._opnFileDialog.ValidateNames = false;
			// 
			// _btnHelp
			// 
			this._btnHelp.Location = new System.Drawing.Point(29, 397);
			this._btnHelp.Name = "_btnHelp";
			this._btnHelp.Size = new System.Drawing.Size(46, 37);
			this._btnHelp.TabIndex = 27;
			this._btnHelp.Text = "????";
			this._btnHelp.UseVisualStyleBackColor = true;
			this._btnHelp.Click += new System.EventHandler(this.OnOpenHelp);
			// 
			// SettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this._btnHelp);
			this.Controls.Add(this._btnSaveProject);
			this.Controls.Add(this._cmbClassList);
			this.Controls.Add(this._txtClass);
			this.Controls.Add(this._btnLoadProject);
			this.Controls.Add(this._btnCreateMarkup);
			this.Controls.Add(this._btnNewProject);
			this.Controls.Add(this._btnBackImg);
			this.Controls.Add(this._btnNextImg);
			this.Name = "SettingControl";
			this.Size = new System.Drawing.Size(115, 466);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnLoadProject;
		private System.Windows.Forms.Button _btnCreateMarkup;
		private System.Windows.Forms.Button _btnNewProject;
		private System.Windows.Forms.Button _btnBackImg;
		private System.Windows.Forms.Button _btnNextImg;
		private System.Windows.Forms.FolderBrowserDialog _folderDialog;
		private System.Windows.Forms.Label _txtClass;
		private System.Windows.Forms.ComboBox _cmbClassList;
		private System.Windows.Forms.Button _btnSaveProject;
		private System.Windows.Forms.OpenFileDialog _opnFileDialog;
		private System.Windows.Forms.Button _btnHelp;
	}
}
