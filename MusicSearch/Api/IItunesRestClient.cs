using MusicSearch.Api.Models;
using System;

namespace MusicSearch.Api
{
	public interface IItunesRestClient
	{
		SearchResponse MakeSearchRequest(String term, String searchEntity);
		SearchResponse MakeSearchRequest(String term, String searchEntity, Int32 limit);
	}
}