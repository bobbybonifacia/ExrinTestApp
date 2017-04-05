using Exrin.Abstraction;
using TestExrinApp.Stacks;

namespace TestExrinApp.Container
{
	public class MainContainer : Exrin.Framework.ViewContainer, ISingleContainer
	{
		public MainContainer(MainStack stack)
						: base(Containers.Main.ToString(), stack.Proxy.NativeView)
		{
			Stack = stack;
		}

		public IStack Stack { get; set; }
	}
}