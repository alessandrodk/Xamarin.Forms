﻿using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Platform.Handlers.DeviceTests.Stubs;
using Xunit;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class CheckBoxHandlerTests : HandlerTestBase<CheckBoxHandler>
	{
		[Theory(DisplayName = "IsChecked Initializes Correctly")]
		[InlineData(true)]
		[InlineData(false)]
		public async Task IsCheckedInitializesCorrectly(bool isChecked)
		{
			var checkBoxStub = new CheckBoxStub()
			{
				IsChecked = isChecked
			};

			await ValidatePropertyInitValue(checkBoxStub, () => checkBoxStub.IsChecked, GetNativeIsChecked, checkBoxStub.IsChecked);
		}

		[Fact(DisplayName = "Color Updates Correctly")]
		public async Task ColorUpdatesCorrectly()
		{
			var checkBoxStub = new CheckBoxStub()
			{
				Color = Color.Red,
				IsChecked = true
			};

			await ValidateColor(checkBoxStub, Color.Red, () => checkBoxStub.Color = Color.Red);
		}
	}
}