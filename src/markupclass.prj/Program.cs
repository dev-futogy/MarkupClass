using System;
using System.Windows.Forms;

using Autofac;

namespace MarkupClass
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using(var container = RegisterServises.Create())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm>());
			}
		}
	}
}
