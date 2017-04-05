using System;
using Exrin.Abstraction;
using Xamarin.Forms.Xaml;

namespace TestExrinApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Third : IView
	{
		public Third()
		{
			InitializeComponent();
		}

		public Func<bool> OnBackButtonPressed { get; set; } = () => false;
	}
}
