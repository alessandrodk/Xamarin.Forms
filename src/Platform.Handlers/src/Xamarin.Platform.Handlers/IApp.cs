﻿using System;
using System.Collections.Generic;

namespace Xamarin.Platform
{
	public interface IApp
	{
		IServiceProvider? Services { get; }

		IHandlerServiceProvider? Handlers { get; }

		IEnumerable<IWindow>? Windows { get; }
	}
}