using System;
using Exrin.Framework;
using TestExrinApp.Interfaces;

namespace TestExrinApp.Models
{
	public class FirstModelState : ModelState
	{
		public int SomeValue
		{
			get { return Get<int>(); }
			set { Set(value); }
		}
	}
}