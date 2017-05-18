using Exrin.Abstraction;
using Exrin.Framework;
using TestExrinApp.Proxy;
using TestExrinApp.ViewModels;
using TestExrinApp.Views;
using Xamarin.Forms;

namespace TestExrinApp.Stacks
{
	public class MainStack : BaseStack
	{
		public MainStack(IViewService viewService)
						: base(new NavigationProxy(new NavigationPage()), viewService, Stack.Main)
		{
			ShowNavigationBar = false;
		}

		protected override void Map()
		{
			NavigationMap<First, FirstViewModel>(nameof(Main.FirstPage));
			NavigationMap<Views.Second, SecondViewModel>(nameof(Main.SecondPage));
			NavigationMap<Third, ThirdViewModel>(nameof(Main.ThirdPage));
			NavigationMap<Fourth, FourthViewModel>(nameof(Main.FourthPage));
			NavigationMap<Fifth, FifthViewModel>(nameof(Main.FifthPage));
		}

		public override string NavigationStartKey => nameof(Main.FirstPage);
	}
}