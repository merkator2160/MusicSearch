using AutoMapper;
using MusicSearch.Api;
using MusicSearch.Api.Models;
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


		public SearchService(IItunesRestClient itunesRestClient, IMapper mapper)
		{
			_itunesRestClient = itunesRestClient;
			_mapper = mapper;
		}


		// IItunesRestClient //////////////////////////////////////////////////////////////////////
		public Task<AlbumDto[]> GetGroupAlbumsAsync(String term)
		{
			return Task<AlbumDto[]>.Factory.StartNew(() =>
			{
				var result = _itunesRestClient.MakeSearchRequest(term, SearchEntities.Album);
				var resultDto = _mapper.Map<AlbumDto[]>(result.Results);

				return resultDto;
			});
		}
	}
}