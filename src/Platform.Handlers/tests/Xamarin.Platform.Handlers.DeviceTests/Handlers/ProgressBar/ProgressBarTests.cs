﻿using System.Threading.Tasks;
using Xamarin.Platform.Handlers.DeviceTests.Stubs;
using Xunit;
using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class ProgressBarHandlerTests : HandlerTestBase<ProgressBarHandler>
	{
		[Theory(DisplayName = "Progress Initializes Correctly")]
		[InlineData(0.25)]
		[InlineData(0.5)]
		[InlineData(0.75)]
		[InlineData(1.0)]
		public async Task ProgressInitializesCorrectly(double progress)
		{
			var progressBar = new ProgressBarStub()
			{
				Progress = progress
			};

			var expected = progressBar.Progress;

			await ValidatePropertyInitValue(progressBar, () => progressBar.Progress, GetNativeProgress, progressBar.Progress);
		}

		[Theory(DisplayName = "Progress Color Initializes Correctly")]
		[InlineData("#FF0000")]
		[InlineData("#00FF00")]
		[InlineData("#0000FF")]
		public async Task ProgressColorInitializesCorrectly(string colorHex)
		{
			Color progressColor = Color.FromHex(colorHex);

			var progressBar = new ProgressBarStub()
			{
				Progress = 0.9,
				ProgressColor = progressColor
			};

			await ValidateNativeProgressColor(progressBar, progressColor);
		}
	}
}