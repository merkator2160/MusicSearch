using AutoMapper;
using MusicSearch.Api.Interfaces;
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
		private readonly IItunesHttpClient _itunesHttpClient;
		private readonly IMapper _mapper;
		private readonly ICache _cache;


		public SearchService(IItunesHttpClient itunesHttpClient, IMapper mapper, ICache cache)
		{
			_itunesHttpClient = itunesHttpClient;
			_mapper = mapper;
			_cache = cache;
		}


		// IItunesHttpClient //////////////////////////////////////////////////////////////////////
		public async Task<AlbumDto[]> GetGroupAlbumsAsync(String term, Int32 limit)
		{
			if(String.IsNullOrEmpty(term))
				throw new ArgumentException($"The {nameof(term)} is empty!");

			if(limit < 1 || limit > 200)
				throw new ArgumentException("Limit must be between 1 and 200");

			var cacheKey = $"{term}:{limit}";

			if(!_cache.TryGetObject<SearchResponse>(cacheKey, out var result))
			{
				result = await _itunesHttpClient.MakeSearchRequestAsync(term, SearchEntities.Album);
				_cache.SetObject(cacheKey, result);
			}

			var resultDto = _mapper.Map<AlbumDto[]>(result.Results);

			return resultDto;
		}
	}
}