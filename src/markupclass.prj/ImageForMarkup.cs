using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupClass
{
	public sealed class ImageForMarkup : IImageForMarkup, IDisposable
	{

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

		public ImageForMarkup()
		{
			ListImg = new List<Classifer>();
			CurerntIamge = 0;
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
				using(FileStream fileForSaveMarkup = new FileStream($"{PathDirectoryImage}\\MarkupForClassifer.txt", FileMode.Create))
				{

					byte[] array = Encoding.Default.GetBytes(TextForSaveMarkup());

					// запись массива байтов в файл
					fileForSaveMarkup.Write(array, 0, array.Length);
				}

			}
		}

		private string TextForSaveMarkup()
		{
			string text = "";

			foreach(var classifier in ListImg)
			{
				if(classifier.IdClass != (int)EnumClassifers.NoClass)
				{
					text += $"{classifier.Name},{classifier.IdClass}\n";
				}
				
			}

			return text;
		}

		#endregion
	}
}
