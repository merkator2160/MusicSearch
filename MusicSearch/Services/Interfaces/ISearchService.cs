using MusicSearch.Services.Models;
using System;
using System.Threading.Tasks;

namespace MusicSearch.Services.Interfaces
{
	public interface ISearchService
	{
		Task<AlbumDto[]> GetGroupAlbumsAsync(String term, Int32 limit);
	}
}