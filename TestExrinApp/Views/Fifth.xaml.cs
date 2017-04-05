using System;
using Exrin.Abstraction;
using Xamarin.Forms.Xaml;

namespace TestExrinApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Fifth : IView
	{
		public Fifth()
		{
			InitializeComponent();
		}

		public Func<bool> OnBackButtonPressed { get; set; } = () => false;
	}
}
