using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class FourthViewModel : ViewModel
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

		public IRelayCommand OpenFithPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FifthPage)));
			}
		}

		public FourthViewModel(IExrinContainer exrinContainer) : base(exrinContainer, null)
		{
		}
	}
}