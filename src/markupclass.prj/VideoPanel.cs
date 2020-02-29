using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkupClass
{
	public partial class VideoPanel : UserControl
	{
		private ImageForMarkup _imageForMarkup;


		#region .ctor

		public VideoPanel(
			ImageForMarkup imageForMarkup)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_imageForMarkup = imageForMarkup;

			_imageForMarkup.OnImageChange += OnImageChange;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{

				_imageForMarkup.OnImageChange -= OnImageChange;
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion


		private void OnImageChange(object sender, string image)
		{
			_framePanel.Image = Image.FromFile(image);
		}
	}
}