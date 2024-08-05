using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages;

namespace TestCRMApp
{
	[Collection("CRMApp")]
	public class TestMaster_View_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Master_View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
