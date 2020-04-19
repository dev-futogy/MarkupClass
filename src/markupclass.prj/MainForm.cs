using System;
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
				_settingControl.SetIdClass((int)PersonalProtectiveType.All);
			}
			if(keyData == Keys.D2)
			{
				_settingControl.SetIdClass((int)PersonalProtectiveType.Helmet);
			}
			if(keyData == Keys.D3)
			{
				_settingControl.SetIdClass((int)PersonalProtectiveType.Vest);
			}
			if(keyData == Keys.D4)
			{
				_settingControl.SetIdClass((int)PersonalProtectiveType.Nothing);
			}
			
			if(keyData == (Keys.Control | Keys.S))
			{
				if(_imageForMarkup.CountImage > 0)
				{
					ProjectSetting.Save(_imageForMarkup, _logText);
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
