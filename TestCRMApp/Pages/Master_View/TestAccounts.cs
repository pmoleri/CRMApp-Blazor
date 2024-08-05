using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages.Master_View;
using CRMApp.Northwind;

namespace TestCRMApp
{
	[Collection("CRMApp")]
	public class TestAccounts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbSelectModule),
				typeof(IgbInputModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbGridModule),
				typeof(IgbRatingModule),
				typeof(IgbTextareaModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Accounts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
