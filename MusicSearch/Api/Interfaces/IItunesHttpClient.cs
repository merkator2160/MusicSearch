using MusicSearch.Api.Models;
using System;
using System.Threading.Tasks;

namespace MusicSearch.Api.Interfaces
{
	public interface IItunesHttpClient
	{
		Task<SearchResponse> MakeSearchRequestAsync(String term, String searchEntity);
		Task<SearchResponse> MakeSearchRequestAsync(String term, String searchEntity, Int32 limit);
	}
}