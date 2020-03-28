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
				switch(_imageForMarkup.ShowClassImg())
				{
					case (int)EnumClassifers.NoClass:
						_txtClass.Text = "Нет класса";
						_txtClass.ForeColor = Color.Black;
						break;
					case (int)EnumClassifers.NoSiz:
						_txtClass.Text = "Нет СИЗов";
						_txtClass.ForeColor = Color.Red;
						break;
					case (int)EnumClassifers.Shlem:
						_txtClass.Text = "Есть каска";
						_txtClass.ForeColor = Color.Blue;
						break;
					case (int)EnumClassifers.Jilet:
						_txtClass.Text = "Есть жилет";
						_txtClass.ForeColor = Color.Orange;
						break;
					case (int)EnumClassifers.AllSiz:
						_txtClass.Text = "Есть все СИЗ";
						_txtClass.ForeColor = Color.Green;
						break;
					default:
						_txtClass.Text = "Нет класса";
						_txtClass.ForeColor = Color.Black;
						break;
				}
			}

		}

		/// <summary> Устанавливает класс - Без СИЗ для текущего изображения.</summary>
		private void OnNoSizClick(object sender, EventArgs e) => SetIdClass((int)EnumClassifers.NoSiz);

		/// <summary> Устанавливает класс - Есть каска для текущего изображения.</summary>
		private void OnCaskaClick(object sender, EventArgs e) => SetIdClass((int)EnumClassifers.Shlem);

		/// <summary> Устанавливает класс - Есть жилет для текущего изображения.</summary>
		private void OnJiletClick(object sender, EventArgs e) => SetIdClass((int)EnumClassifers.Jilet);

		/// <summary> Устанавливает класс - Есть все СИЗ для текущего изображения.</summary>
		private void OnAllSizClick(object sender, EventArgs e) => SetIdClass((int)EnumClassifers.AllSiz);

		/// <summary> Сохранить разметку.</summary>
		private void OnSaveMarkup(object sender, EventArgs e) => _imageForMarkup.SaveMarkup();

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
			if(_folderDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string path = _folderDialog.SelectedPath;

			filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp")|| s.EndsWith(".jpeg"));

			if(_imageForMarkup.ListImg.Count != 0)
				_imageForMarkup.ListImg.Clear();


			foreach(var item in filesDirectory)
				_imageForMarkup.AddImageInList(item, Path.GetFileName(item));

			_imageForMarkup.PathDirectoryImage = path;

			_imageForMarkup.ShowImg();
			ChangeTextClass();
			_log.AddMessage("Папка открыта.");
		}
	}
} 
