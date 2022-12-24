using FluentAssertions.Primitives;

namespace Ave.Extensions.Functional.FluentAssertions
{
	public class ResultAssertions<T,E> : ReferenceTypeAssertions<Result<T,E>, ResultAssertions<T,E>>
	{
		public ResultAssertions(Result<T,E> instance)
			: base(instance)
		{
		}

		protected override string Identifier => "Result{T,E}";
	}
}
