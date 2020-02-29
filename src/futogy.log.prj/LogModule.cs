using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace Futogy.Log
{
	public sealed class LogModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);
			builder
				.RegisterType<Log>()
				.AsSelf()
				.SingleInstance();

			builder
				.RegisterType<LogControl>()
				.AsSelf()
				.SingleInstance();
		}
	}
}
