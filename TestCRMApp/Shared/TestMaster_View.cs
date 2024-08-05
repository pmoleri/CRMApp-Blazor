using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Shared;

namespace TestCRMApp
{
	[Collection("CRMApp")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
