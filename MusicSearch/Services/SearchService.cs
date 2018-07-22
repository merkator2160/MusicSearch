using MusicSearch.Api;
using MusicSearch.Api.Models;
using MusicSearch.Services.Interfaces;
using System.Threading.Tasks;

namespace MusicSearch.Services
{
	public class SearchService : ISearchService
	{
		private readonly IItunesRestClient _itunesRestClient;


		public SearchService(IItunesRestClient itunesRestClient)
		{
			_itunesRestClient = itunesRestClient;
		}


		// IItunesRestClient //////////////////////////////////////////////////////////////////////
		public Task<SearchResponse> GetGroupAlbumsAsync()
		{
			return Task<SearchResponse>.Factory.StartNew(() =>
			{
				var result = _itunesRestClient.MakeSearchRequest("lube", SearchEntities.Album);

				return result;
			});
		}
	}
}