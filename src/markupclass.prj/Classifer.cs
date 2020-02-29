using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupClass
{
	public class Classifer
	{
		public string Name{ get; set;}
		public int IdClass { get; set;}
		public string Path { get; set;}

		public Classifer(string path, string name, int idclass)
		{
			Path = path;
			Name = name;
			IdClass = idclass;
		}

	}
}
