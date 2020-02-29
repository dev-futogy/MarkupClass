using Autofac;

using Futogy.Log;

namespace MarkupClass
{
	public static class RegisterServises
	{

		public static IContainer Create()
		{
			var containerBulder = new ContainerBuilder();

			containerBulder
				.RegisterModule<ModuleMarkupClass>();
			containerBulder
				.RegisterModule<LogModule>();

			containerBulder
				.RegisterType<MainForm>()
				.AsSelf();

			return containerBulder.Build();

		}
	}
}
