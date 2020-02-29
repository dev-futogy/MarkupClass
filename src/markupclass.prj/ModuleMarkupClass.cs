using Autofac;

namespace MarkupClass
{
	public sealed class ModuleMarkupClass : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);
			builder
				.RegisterType<ImageForMarkup>()
				.As<IImageForMarkup>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<SettingControl>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<VideoPanel>()
				.AsSelf()
				.SingleInstance();

		}
	}
}
