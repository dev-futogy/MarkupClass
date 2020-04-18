using Futogy.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarkupClass
{
	/// <summary> Настройки проекта. </summary>
	public static class ProjectSetting
	{
		/// <summary> Сохранить проект. </summary>
		public static void Save(ImageForMarkup markup, Log log)
		{
			XElement element;

			XDocument xdoc = new XDocument();
			XElement project = new XElement("MarkupClassifierProjectSetting");

			element = new XElement("PathDirectoryImage", markup.PathDirectoryImage);
			project.Add(element);

			element = new XElement("CountImage", markup.CountImage);
			project.Add(element);

			element = new XElement("CurerntIamge", markup.CurerntIamge);
			project.Add(element);

			element = new XElement("ImageList");
			XElement ximage;
			XElement xid;
			XAttribute xAttribute;
			foreach(var image in markup.ListImg)
			{
				xid = new XElement("Image");

				xAttribute = new XAttribute("id", markup.ListImg.IndexOf(image));
				xid.Add(xAttribute);

				ximage = new XElement("PathImage", image.Path);
				xid.Add(ximage);

				ximage = new XElement("NameImage", image.Name);
				xid.Add(ximage);

				ximage = new XElement("IdClassImage", image.IdClass);
				xid.Add(ximage);

				element.Add(xid);
			}
			project.Add(element);


			xdoc.Add(project);

			xdoc.Save($"{markup.PathDirectoryImage}\\project.xml");

			log.AddMessage("Проект сохранен. Возвращяйтесь скорее, чтобы разметить еще пару картинок.");

		}

		/// <summary> Загруить проект. </summary>
		public static void Load(ImageForMarkup markup, Log log, string path)
		{
			XDocument doc = XDocument.Load(path);

			markup.PathDirectoryImage = doc.Root.Element("PathDirectoryImage").Value;
			markup.CurerntIamge = int.Parse(doc.Root.Element("CurerntIamge").Value);


			var filesDirectory = Directory.EnumerateFiles(markup.PathDirectoryImage, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));

			if(markup.ListImg.Count != 0)
				markup.ListImg.Clear();

			foreach(var item in filesDirectory)
				markup.AddImageInList(item, Path.GetFileName(item));

			if(markup.CountImage != int.Parse(doc.Root.Element("CountImage").Value))
			{
				MessageBox.Show("Ранее в этой папке было другое колличество картинок. Могут быть проблемы. Проект может быть открыт не корректно.",
					"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


			foreach(XElement imageElement in doc.Root.Element("ImageList").Elements("Image"))
			{
				XAttribute idAttribute = imageElement.Attribute("id");
				XElement idClassElement = imageElement.Element("IdClassImage");

				if(idAttribute != null && idClassElement != null)
				{
					markup.ListImg[int.Parse(idAttribute.Value)].IdClass = int.Parse(idClassElement.Value);
				}
			}

			log.AddMessage("Проект загружен. Спасибо, что вернулись к работе!");

		}

	}
}
