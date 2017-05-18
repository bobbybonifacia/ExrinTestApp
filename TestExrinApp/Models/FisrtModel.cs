using Exrin.Abstraction;
using Exrin.Framework;
using TestExrinApp.Interfaces;

namespace TestExrinApp.Models
{
	public class FisrtModel : Model, IFisrtModel
	{
		public FisrtModel(IExrinContainer exrinContainer) : base(exrinContainer, new FirstModelState())
		{
		}
	}
}