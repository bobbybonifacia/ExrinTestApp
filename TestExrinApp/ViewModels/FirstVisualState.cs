using System;
using Exrin.Abstraction;
using Exrin.Framework;
using TestExrinApp.Interfaces;

namespace TestExrinApp.ViewModels
{
	public class FirstVisualState : VisualState
	{
		[Binding(BindingType.TwoWay)]
		public int SomeValue
		{
			get { return Get<int>(); }
			set { Set(value); }
		}

		public FirstVisualState(IBaseModel model) : base(model)
		{
		}
	}
}