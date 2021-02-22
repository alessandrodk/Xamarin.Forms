﻿using static Android.Resource;
using AndroidProgressBar = Android.Widget.ProgressBar;

namespace Xamarin.Platform.Handlers
{
	public partial class ProgressBarHandler : AbstractViewHandler<IProgress, AndroidProgressBar>
	{
		protected override AndroidProgressBar CreateNativeView()
		{
			return new AndroidProgressBar(Context, null, Attribute.ProgressBarStyleHorizontal)
			{
				Indeterminate = false,
				Max = ProgressBar.Maximum
			};
		}
	}
}