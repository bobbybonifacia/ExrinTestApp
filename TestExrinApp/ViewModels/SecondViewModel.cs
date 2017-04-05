using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class SecondViewModel : ViewModel
	{
		public IRelayCommand OpenThirdPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.ThirdPage)));
			}
		}

		public IRelayCommand OpenFirstPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FirstPage)));
			}
		}

		public SecondViewModel(IExrinContainer exrinContainer) : base(exrinContainer, null)
		{
		}
	}
}