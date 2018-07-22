using System;

namespace MusicSearch.Api.Models
{
	public class SearchResponse
	{
		public Int32 ResultCount { get; set; }
		public SearchResponseItem[] Results { get; set; }
	}
}