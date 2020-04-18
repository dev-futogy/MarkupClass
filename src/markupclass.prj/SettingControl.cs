using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

using Futogy.Log;
using System.Linq;
using System.Collections.Generic;

namespace MarkupClass
{
	public partial class SettingControl : UserControl
	{
		private ImageForMarkup _imageForMarkup;
		private Log _log;
		private IEnumerable<string> filesDirectory;


		#region .ctor

		/// <summary> Создать контрол управления.</summary>
		public SettingControl(
			ImageForMarkup imageForMarkup,
			Log log)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_imageForMarkup = imageForMarkup;
			_log = log;
			
		}

		/// <summary> Clean up any resources being used. </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion

		/// <summary> Вызывается при нежатие "Открыть". Выбор папки с картинами.</summary>
		private void OnOpenImgClick(object sender, EventArgs e) => OpenFolderImage();

		/// <summary> Следующее изображение.</summary>
		private void OnNextImageClick(object sender, EventArgs e)
		{
			_imageForMarkup.NextImage();
			ChangeTextClass();
		}

		/// <summary> Предыдущее изображение.</summary>
		private void OnBackImageClick(object sender, EventArgs e)
		{
			_imageForMarkup.BackImage();
			ChangeTextClass();
		}

		/// <summary> Отобразить название класса на текущем изображении.</summary>
		public void ChangeTextClass()
		{
			if(_imageForMarkup != null)
			{
				_txtClass.Text = new GetNameClass(_imageForMarkup.ShowClassImg()).ToString();
				_txtClass.ForeColor = new GetNameClass(_imageForMarkup.ShowClassImg()).ToColor();

			}

		}

		/// <summary> Вызывается при нажатии на кнопку "Генерация".</summary>
		private void OnSaveMarkup(object sender, EventArgs e) => _imageForMarkup.GenerateMarkup();

		/// <summary> Устнановить номер класса.</summary>
		/// <param name="idClass">ID класса.</param>
		public void SetIdClass(int idClass)
		{
			_imageForMarkup.SetClassImg(idClass);
			ChangeTextClass();
		}

		/// <summary> Открыть папку с картинками для разметки. </summary>
		public void OpenFolderImage()
		{
			_folderDialog.Description = "Укажите папку с изображениями для рамзетки.\nВ ней будет создан файл проекта.";
			if(_folderDialog.ShowDialog() == DialogResult.Cancel) return;

			string path = _folderDialog.SelectedPath;

			filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp")|| s.EndsWith(".jpeg"));

			if(_imageForMarkup.ListImg.Count != 0)
				_imageForMarkup.ListImg.Clear();


			foreach(var item in filesDirectory)
				_imageForMarkup.AddImageInList(item, Path.GetFileName(item));

			_imageForMarkup.PathDirectoryImage = path;


			OnEnabledElement();
			_imageForMarkup.ShowImg();
			ChangeTextClass();
			_log.AddMessage("Папка открыта.");
		}

		/// <summary> Открывает элементы управления. </summary>
		private void OnEnabledElement()
		{
			_btnNewProject.Enabled = false;
			_btnLoadProject.Enabled = false;

			_btnBackImg.Enabled = true;
			_btnNextImg.Enabled = true;
			_btnSaveProject.Enabled = true;
			_btnCreateMarkup.Enabled = true;
			_cmbClassList.Enabled = true;

			_txtClass.Enabled = true;
		}


		/// <summary> Вызывается при выборе класса из всплывающего меню. </summary>
		private void OnChangeIndexCmbClass(object sender, EventArgs e)
		{
			SetIdClass(_cmbClassList.SelectedIndex);
		}

		/// <summary> Вызывается при нажатии на кнопку "Сохранить". </summary>
		private void OnSaveProject(object sender, EventArgs e)
		{
			if(_imageForMarkup.CountImage > 0)
			{
				ProjectSetting.Save(_imageForMarkup,_log);
			}
		}

		/// <summary> Вызывается при нажтие кнопки "Загрузить проект". </summary>
		private void OnOpenLoadProject(object sender, EventArgs e)
		{
			_folderDialog.Description = "Укажите папку с проектом.\nУспехов в работе!.";
			if(_folderDialog.ShowDialog() == DialogResult.Cancel) return;

			string path = _folderDialog.SelectedPath +"\\project.xml";

			ProjectSetting.Load(_imageForMarkup, _log, path);
			OnEnabledElement();
			_imageForMarkup.ShowImg();
			ChangeTextClass();

		}

		private void OnOpenHelp(object sender, EventArgs e)
		{
			using( var formHelp = new HelpForm())
			{
				formHelp.ShowDialog();
			}
		}
	}
} 
