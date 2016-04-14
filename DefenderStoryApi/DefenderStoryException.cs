using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefenderStory.Api
{

	[Serializable]
	public class DefenderStoryException : Exception
	{
		public DefenderStoryException() { }
		public DefenderStoryException(string message) : base(message) { }
		public DefenderStoryException(string message, Exception inner) : base(message, inner) { }
		protected DefenderStoryException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{ }
	}
}
