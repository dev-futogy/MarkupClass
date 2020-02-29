using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

using Futogy.Log;

namespace MarkupClass
{
	public partial class SettingControl : UserControl
	{
		private ImageForMarkup _imageForMarkup;
		private Log _log;


		#region .ctor

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
			_imageForMarkup.SaveMarkup();
			if(disposing && (components != null))
			{
				
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion

		/// <summary> Вызывается при нежатие "Открыть". Выбор папки с картинами.</summary>
		private void OnOpenImgClick(object sender, EventArgs e)
		{

			if(_folderDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string path = _folderDialog.SelectedPath;

			DirectoryInfo directoryInfo = new DirectoryInfo(path);

			if(_imageForMarkup.ListImg.Count != 0)
				_imageForMarkup.ListImg.Clear();

			foreach(var item in directoryInfo.GetFiles("*.jpg"))
				_imageForMarkup.AddImageInList(item.FullName,item.Name);

			_imageForMarkup.PathDirectoryImage = path;

			_imageForMarkup.ShowImg();
			ChangeTextClass();
			_log.AddMessage("Папка открыта.");

		}

		private void OnNextImageClick(object sender, EventArgs e)
		{
			_imageForMarkup.NextImage();
			ChangeTextClass();
		}

		private void OnBackImageClick(object sender, EventArgs e)
		{
			_imageForMarkup.BackImage();
			ChangeTextClass();
		}

		/// <summary> Отобразить название класса на текущем изображении.</summary>
		private void ChangeTextClass()
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
					case (int)EnumClassifers.All:
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
		private void OnNoSizClick(object sender, EventArgs e)
		{
			_imageForMarkup.SetClassImg((int)EnumClassifers.NoSiz);
			ChangeTextClass();
			
		}

		/// <summary> Устанавливает класс - Есть каска для текущего изображения.</summary>
		private void OnCaskaClick(object sender, EventArgs e)
		{
			_imageForMarkup.SetClassImg((int)EnumClassifers.Shlem);
			ChangeTextClass();
		}

		/// <summary> Устанавливает класс - Есть жилет для текущего изображения.</summary>
		private void OnJiletClick(object sender, EventArgs e)
		{
			_imageForMarkup.SetClassImg((int)EnumClassifers.Jilet);
			ChangeTextClass();
		}

		/// <summary> Устанавливает класс - Есть все СИЗ для текущего изображения.</summary>
		private void OnAllSizClick(object sender, EventArgs e)
		{
			_imageForMarkup.SetClassImg((int)EnumClassifers.All);
			ChangeTextClass();
		}

		private void OnSaveMarkup(object sender, EventArgs e)
		{
			_imageForMarkup.SaveMarkup();
		}

		private void _txtClass_Click(object sender, EventArgs e)
		{

		}
	}
} 
