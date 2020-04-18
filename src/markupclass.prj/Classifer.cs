using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupClass
{
	public class Classifer
	{
		/// <summary> Имя картинки </summary>
		public string Name{ get; set;}

		/// <summary> Ид выбранного класса для картинки. </summary>
		public int IdClass { get; set;}

		/// <summary> Полный путь к картинке </summary>
		public string Path { get; set;}

		/// <summary> Создает из картинки элемент выбороки для классификатора. </summary>
		/// <param name="path"> Путь к картинке. </param>
		/// <param name="name"> Имя картинки. </param>
		/// <param name="idclass"> Ид класса. </param>
		public Classifer(string path, string name, int idclass)
		{
			Path = path;
			Name = name;
			IdClass = idclass;
		}

	}
}
