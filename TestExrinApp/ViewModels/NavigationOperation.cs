using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Exrin.Abstraction;
using Exrin.Framework;

namespace TestExrinApp.ViewModels
{
	public class NavigationOperation : ISingleOperation
	{
		private object stack;
		private object viewKey;

		public Func<Task> Rollback { get; }
		public bool ChainedRollback { get; }

		public Func<object, CancellationToken, Task<IList<IResult>>> Function
		{
			get
			{
				return (parameter, cancellationToken) =>
				{
					IList<IResult> results = new List<IResult>();
					results.Add(new NavigationResult(stack, viewKey, parameter, false));
					return Task.FromResult(results);
				};
			}
		}

		public NavigationOperation(object stack, object viewKey)
		{
			this.stack = stack;
			this.viewKey = viewKey;
		}
	}
}