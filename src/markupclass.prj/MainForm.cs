using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Futogy.Log;

namespace MarkupClass
{
	public partial class MainForm : Form
	{

		private SettingControl _settingControl;
		private VideoPanel _videoPanel;
		private LogControl _log;
		private Log _logText;
		private ImageForMarkup _imageForMarkup;


		public MainForm(
			SettingControl setting,
			VideoPanel video,
			LogControl log,
			Log logtext,
			ImageForMarkup image)
		{
			InitializeComponent();

			_settingControl = setting;
			_videoPanel = video;
			_log = log;
			_logText = logtext;
			_imageForMarkup = image;

			_pnlSetting.Controls.Add(_settingControl);
			_pnlFrame.Controls.Add(_videoPanel);
			_pnlLog.Controls.Add(_log);

		}

		protected override void Dispose(bool disposing)
		{
			_imageForMarkup.SaveMarkup();
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Right)
			{
				_imageForMarkup.NextImage();
				_settingControl.ChangeTextClass();
				return true;
			}
			if(keyData == Keys.Left)
			{

				_imageForMarkup.BackImage();
				_settingControl.ChangeTextClass();
				return true;
			}
			if(keyData == Keys.D1)
			{
				_settingControl.SetIdClass((int)EnumClassifers.NoSiz);
			}
			if(keyData == Keys.D2)
			{
				_settingControl.SetIdClass((int)EnumClassifers.Shlem);
			}
			if(keyData == Keys.D3)
			{
				_settingControl.SetIdClass((int)EnumClassifers.Jilet);
			}
			if(keyData == Keys.D4)
			{
				_settingControl.SetIdClass((int)EnumClassifers.AllSiz);
			}
			if(keyData == (Keys.Control | Keys.S))
			{
				_imageForMarkup.SaveMarkup();
			}
			if(keyData == (Keys.Control | Keys.O))
			{
				_settingControl.OpenFolderImage();
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
