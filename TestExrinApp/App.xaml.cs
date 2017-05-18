using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			Bootstrapper.GetInstance()
												.Init()
												.Get<INavigationService>()
												.Navigate(new StackOptions
												{
													StackChoice = Stack.Main,
													ViewKey = Main.SecondPage.ToString()
												});
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
