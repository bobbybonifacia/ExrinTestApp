using System;
using Exrin.Abstraction;
using Xamarin.Forms.Xaml;

namespace TestExrinApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Fourth : IView
	{
		public Fourth()
		{
			InitializeComponent();
		}

		public Func<bool> OnBackButtonPressed { get; set; } = () => false;
	}
}
