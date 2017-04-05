using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class FifthViewModel : ViewModel
	{
		public IRelayCommand OpenFirstPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FirstPage)));
			}
		}

		public IRelayCommand OpenSecondPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.SecondPage)));
			}
		}

		public IRelayCommand OpenThirdPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.ThirdPage)));
			}
		}

		public IRelayCommand OpenFourthPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FourthPage)));
			}
		}

		public FifthViewModel(IExrinContainer exrinContainer) : base(exrinContainer, null)
		{
		}
	}
}