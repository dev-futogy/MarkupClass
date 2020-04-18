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
				_settingControl.SetIdClass((int)CarType.Car);
			}
			if(keyData == Keys.D2)
			{
				_settingControl.SetIdClass((int)CarType.CarWithTrailer);
			}
			if(keyData == Keys.D3)
			{
				_settingControl.SetIdClass((int)CarType.MiniTruck);
			}
			if(keyData == Keys.D4)
			{
				_settingControl.SetIdClass((int)CarType.Truck);
			}
			if(keyData == Keys.D5)
			{
				_settingControl.SetIdClass((int)CarType.BigTruck);
			}
			if(keyData == Keys.D6)
			{
				_settingControl.SetIdClass((int)CarType.Hauler);
			}
			if(keyData == Keys.D7)
			{
				_settingControl.SetIdClass((int)CarType.MiniBus);
			}
			if(keyData == Keys.D8)
			{
				_settingControl.SetIdClass((int)CarType.Bus);
			}
			if(keyData == Keys.D9)
			{
				_settingControl.SetIdClass((int)CarType.LongBus);
			}
			if(keyData == Keys.D0)
			{
				_settingControl.SetIdClass((int)CarType.Bike);
			}
			if(keyData == Keys.OemMinus)
			{
				_settingControl.SetIdClass((int)CarType.SpecialCar);
			}
			if(keyData == Keys.Oemplus)
			{
				_settingControl.SetIdClass((int)CarType.EmergencyCar);
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
