using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class FirstViewModel : ViewModel
	{
		public IRelayCommand OpenSecondPageCommand
		{
			get
			{
				return GetCommand(() => Execution.ViewModelExecute(new NavigationOperation(Stack.Main, Main.SecondPage)));
			}
		}

		public FirstViewModel(IExrinContainer exrinContainer) : base(exrinContainer, null)
		{
		}
	}
}