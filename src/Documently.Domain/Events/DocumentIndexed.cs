using System;

namespace Documently.Domain.Events
{
	[Serializable]
	public class DocumentIndexed : DomainEvent
	{
		/// <summary> for serialization </summary>
		[Obsolete("for serialization")]
		protected DocumentIndexed()
		{
		}

		public DocumentIndexed(Guid arId, uint arVersion) : base(arId, arVersion)
		{
		}
	}
}