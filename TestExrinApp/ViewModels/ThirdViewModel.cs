using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class ThirdViewModel : ViewModel
	{
		public IRelayCommand OpenFourthPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FourthPage)));
			}
		}

		public IRelayCommand OpenSecondPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.SecondPage)));
			}
		}

		public IRelayCommand OpenFirstPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.FirstPage)));
			}
		}

		public ThirdViewModel(IExrinContainer exrinContainer) : base(exrinContainer, null)
		{
		}
	}
}