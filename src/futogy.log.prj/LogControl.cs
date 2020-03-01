using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futogy.Log
{
	public partial class LogControl : UserControl
	{
		private Log _log;


		public LogControl(
			Log log)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_log = log;
			_log.EventAddMessage += OnAddMessageLog;
		}

		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
			_log.EventAddMessage -= OnAddMessageLog;

		}

		private void OnAddMessageLog(object sender, string text)
		{
			if(_txtLog != null)
			{
				_txtLog.AppendText(text);
			}
			
		}
	}
}
