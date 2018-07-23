using AutoMapper;
using MusicSearch.Api;
using MusicSearch.Api.Models;
using MusicSearch.Core.Cache;
using MusicSearch.Services.Interfaces;
using MusicSearch.Services.Models;
using System;
using System.Threading.Tasks;

namespace MusicSearch.Services
{
	public class SearchService : ISearchService
	{
		private readonly IItunesRestClient _itunesRestClient;
		private readonly IMapper _mapper;
		private readonly ICache _cache;


		public SearchService(IItunesRestClient itunesRestClient, IMapper mapper, ICache cache)
		{
			_itunesRestClient = itunesRestClient;
			_mapper = mapper;
			_cache = cache;
		}


		// IItunesRestClient //////////////////////////////////////////////////////////////////////
		public Task<AlbumDto[]> GetGroupAlbumsAsync(String term, Int32 limit)
		{
			if(limit < 1 || limit > 200)
				throw new ArgumentException("Limit must be between 1 and 200");
			
			return Task<AlbumDto[]>.Factory.StartNew(() =>
			{
				var cacheKey = $"{term}:{limit}";

				if (!_cache.TryGetObject<SearchResponse>(cacheKey, out var result))
				{
					result = _itunesRestClient.MakeSearchRequest(term, SearchEntities.Album);
					_cache.SetObject(cacheKey, result);
				}
				
				var resultDto = _mapper.Map<AlbumDto[]>(result.Results);

				return resultDto;
			});
		}
	}
}