using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Futogy.Log;

namespace MarkupClass
{
	public sealed class ImageForMarkup : IImageForMarkup, IDisposable
	{

		#region Data

		private Log _log;

		#endregion

		#region Event

		public event EventHandler<string> OnImageChange;

		private void OnImageChangeEvent(string img)
		{
			if(OnImageChange != null)
			{
				OnImageChange.Invoke(null, img);
			}
		}

		#endregion

		#region Property

		public List<Classifer> ListImg { get; private set; }

		public int CurerntIamge { get; private set; }

		public int CountImage { get => ListImg.Count-1;}

		public string PathDirectoryImage { get; set; }

		#endregion

		#region .ctor

		public ImageForMarkup(
			Log log)
		{
			ListImg = new List<Classifer>();
			CurerntIamge = 0;

			_log = log;
		}

		public void Dispose()
		{

		}

		#endregion

		#region Methods

		/// <summary> Добавить путь к картинке в список.</summary>
		/// <param name="image"> Путь.</param>
		public void AddImageInList(string imagepath,string imagename,int numclass = 0)
		{

			ListImg?.Add(new Classifer(imagepath, imagename, numclass));
		}

		/// <summary> Показать текущую картинку.</summary>
		public void ShowImg()
		{
			if(ListImg != null && ListImg.Count != 0)
			{
				OnImageChangeEvent(ListImg[CurerntIamge].Path);
			}
			
		}

		/// <summary> Cледующее изображение. </summary>
		public void NextImage()
		{
			if(ListImg != null && ListImg.Count != 0)
			{
				CurerntIamge++;
				if(CurerntIamge > CountImage)
				{
					CurerntIamge = 0;
				}
				ShowImg();

			}
		}

		/// <summary> Предыдущее изображение.</summary>
		public void BackImage()
		{
			if(ListImg != null && ListImg.Count != 0)
			{
				CurerntIamge--;
				if(CurerntIamge < 0)
				{
					CurerntIamge = CountImage;
				}
				ShowImg();

			}
		}

		/// <summary> Узнать ID класса текущего изображения.</summary>
		/// <returns> ID класса</returns>
		public int ShowClassImg()
		{
			if(ListImg == null || ListImg.Count == 0)
			{
				return 0;
			}
			else
			{
				return ListImg[CurerntIamge].IdClass;
			}
			
		}

		/// <summary> Установить класс для текущего изображения.</summary>
		/// <param name="idClass"> ID класса..</param>
		public void SetClassImg(int idClass)
		{
			if(ListImg != null && ListImg.Count != 0)
			{
				ListImg[CurerntIamge].IdClass = idClass;
			}
		}


		/// <summary> Сохранить разметку.</summary>
		public void SaveMarkup()
		{
			if(ListImg != null && ListImg.Count != 0)
			{
				using(FileStream fileForSaveMarkup = new FileStream($"{PathDirectoryImage}\\MarkupForClassifer.csv", FileMode.Create))
				{

					byte[] array = Encoding.Default.GetBytes(TextForSaveMarkup());

					// запись массива байтов в файл
					fileForSaveMarkup.Write(array, 0, array.Length);
				}
				_log.AddMessage("Файл разметки сохранен.");
			}
		}


		private string GetNameClass(int IDClass)
		{
			switch(IDClass)
			{

				case (int)EnumClassifers.NoSiz:
					return "NoSiz";
				case (int)EnumClassifers.Shlem:
					return "Shlem";
				case (int)EnumClassifers.Jilet:
					return "Jilet";
				case (int)EnumClassifers.AllSiz:
					return "AllSiz";
			}
			return null;
		}


		private string TextForSaveMarkup()
		{
			string text = "IdImage,Class\n";

			foreach(var classifier in ListImg)
			{
				if(classifier.IdClass != (int)EnumClassifers.NoClass)
				{
					text += $"{Path.GetFileNameWithoutExtension(classifier.Name)},{GetNameClass(classifier.IdClass)}\n";
				}
				
			}

			return text;
		}

		#endregion
	}
}
