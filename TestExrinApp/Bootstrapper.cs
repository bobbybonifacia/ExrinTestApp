using System;
using Exrin.Abstraction;
using TestExrinApp.Proxy;
using Xamarin.Forms;

namespace TestExrinApp
{
	public class Bootstrapper : Exrin.Framework.Bootstrapper
	{
		private static Bootstrapper _instance = null;
		private Func<object> _rootGet;
		private Action<object> _rootSet;
		public Bootstrapper(IInjectionProxy injection, Action<object> setRoot, Func<object> getRoot)
				: base(injection, setRoot, getRoot)
		{
			_rootGet = getRoot;
			_rootSet = setRoot;
		}

		public static Bootstrapper GetInstance()
		{
			if (_instance == null)
				_instance = new Bootstrapper(new Injection(), (view) => Application.Current.MainPage = view as Page, () => { return Application.Current.MainPage; });

			return _instance;
		}

	}
}