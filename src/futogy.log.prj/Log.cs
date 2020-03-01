using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futogy.Log
{
	public class Log
	{

		public event EventHandler<string> EventAddMessage;

		private void OnAddMassage(string text)
		{
			if(EventAddMessage != null)
			{
				EventAddMessage.Invoke(this, text);
			}
		}

		/// <summary> Добавить Сообщение в ЛОГ.</summary>
		/// <param name="text">Тест сообщения.</param>
		public void AddMessage(string text)
		{
			var msg = $"[{DateTime.Now}] - " + text + "\n";
			OnAddMassage(msg);
		}

	}
}
