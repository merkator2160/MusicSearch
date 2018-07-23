using MusicSearch.Api.Models;
using MusicSearch.Core.Config;
using MusicSearch.Core.Config.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace MusicSearch.Api
{
	public class ItunesRestClient : IItunesRestClient
	{
		private readonly ItunesConfig _config;


		public ItunesRestClient(IConfig configProvider)
		{
			_config = configProvider.GetItunesConfig();
		}


		// IItunesApiClient ///////////////////////////////////////////////////////////////////////
		public SearchResponse MakeSearchRequest(String term, String searchEntity)
		{
			return MakeSearchRequest(term, searchEntity, 50);
		}
		public SearchResponse MakeSearchRequest(String term, String searchEntity, Int32 limit)
		{
			if(limit < 1 || limit > 200)
				throw new ArgumentException("Limit must be between 1 and 200");

			var requestUrl = $"{_config.ItunesApiSearchUri}?term={term}&entity={searchEntity}&limit={limit}";

			using (var httpClient = new HttpClient())
			{
				using(var response = httpClient.GetAsync(requestUrl).Result)
				{
					if(!response.IsSuccessStatusCode)
						throw new InvalidOperationException($"Response status code: {response.StatusCode}");
					
					var responseJson = response.Content.ReadAsStringAsync().Result;
					return JsonConvert.DeserializeObject<SearchResponse>(responseJson);
				}
			}
		}
	}
}