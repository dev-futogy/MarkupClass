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


		public MainForm(
			SettingControl setting,
			VideoPanel video,
			LogControl log)
		{
			InitializeComponent();

			_settingControl = setting;
			_videoPanel = video;
			_log = log;

			_pnlSetting.Controls.Add(_settingControl);
			_pnlFrame.Controls.Add(_videoPanel);
			_pnlLog.Controls.Add(_log);

		}

	}
}
