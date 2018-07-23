using System;
using System.Net;

namespace MusicSearch.Api.Exceptions
{
	public class HttpServerException : Exception
	{
		public HttpServerException(HttpStatusCode statusCode, string message) : base(message)
		{
			StatusCode = statusCode;
		}

		public HttpStatusCode StatusCode { get; }
	}
}