using Xamarin.Platform.Handlers;

namespace Xamarin.Forms
{
	public static class FormsHandlers
	{
		// This is used to register the handler version against the xplat code so that the handler version will be used
		// when running a full Xamarin.Forms application. This lets us test the handler code inside the Control Gallery
		// And other scenarios
		public static void InitHandlers()
		{
			Xamarin.Platform.Registrar.Handlers.Register<VerticalStackLayout, LayoutHandler>();
			Xamarin.Platform.Registrar.Handlers.Register<HorizontalStackLayout, LayoutHandler>();
			Xamarin.Platform.Registrar.Handlers.Register<Button, ButtonHandler>();
			Xamarin.Platform.Registrar.Handlers.Register<Label, LabelHandler>();
			Xamarin.Platform.Registrar.Handlers.Register(typeof(Switch), typeof(SwitchHandler));
			Xamarin.Platform.Registrar.Handlers.Register(typeof(Slider), typeof(SliderHandler));
			Platform.Registrar.Handlers.Register<Entry, EntryHandler>();
		}
	}
}
