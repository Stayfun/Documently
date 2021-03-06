﻿using CommonDomain.Core;
using Documently.Domain.Events;
using Magnum;

namespace Documently.Domain.Domain
{
	public class DocumentCollection : AggregateBase
	{
		public DocumentCollection()
		{
		}

		protected DocumentCollection(string collectionName)
		{
			var @event = new DocumentCollectionCreated(CombGuid.Generate(), collectionName);
			RaiseEvent(@event);
		}

		public void Apply(DocumentCollectionCreated evt)
		{
			Id = evt.AggregateId;
		}

		public static DocumentCollection CreateNew(string collectionName = "")
		{
			if (string.IsNullOrEmpty(collectionName))
			{
				collectionName = "Default name";
			}

			return new DocumentCollection(collectionName);
		}
	}
}