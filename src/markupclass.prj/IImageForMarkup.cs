using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupClass
{
	public interface IImageForMarkup
	{
		public void AddImageInList(string imagepath,string imagename,int numclass);
		public void ShowImg();
		public void NextImage();
		public void BackImage();
		public void SaveMarkup();
	}

}
