using Exrin.Abstraction;
using Exrin.Framework;
using TestExrinApp.Interfaces;

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

		public FirstViewModel(IExrinContainer exrinContainer, IFisrtModel model) : base(exrinContainer, new FirstVisualState(model))
		{
		}
	}
}