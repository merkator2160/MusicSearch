using MusicSearch.Api.Interfaces;
using MusicSearch.Api.Models;
using MusicSearch.Core.Config;
using MusicSearch.Core.Config.Models;
using System;
using System.Threading.Tasks;

namespace MusicSearch.Api
{
	public class ItunesHttpClient : TypedHttpClient, IItunesHttpClient
	{
		private readonly ItunesConfig _config;


		public ItunesHttpClient(IConfig configProvider)
		{
			_config = configProvider.GetItunesConfig();
		}


		// IItunesHttpClient ///////////////////////////////////////////////////////////////////////
		public async Task<SearchResponse> MakeSearchRequestAsync(String term, String searchEntity)
		{
			return await MakeSearchRequestAsync(term, searchEntity, 50);
		}
		public async Task<SearchResponse> MakeSearchRequestAsync(String term, String searchEntity, Int32 limit)
		{
			return await GetObjectAsync<SearchResponse>($"{_config.ItunesApiSearchUri}?term={term}&entity={searchEntity}&limit={limit}");
		}
	}
}