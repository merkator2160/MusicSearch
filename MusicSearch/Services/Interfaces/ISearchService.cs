using MusicSearch.Api.Models;
using System.Threading.Tasks;

namespace MusicSearch.Services.Interfaces
{
	public interface ISearchService
	{
		Task<SearchResponse> GetGroupAlbumsAsync();
	}
}