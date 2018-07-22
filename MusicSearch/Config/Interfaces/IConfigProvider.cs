using MusicSearch.Config.Models;

namespace MusicSearch.Config.Interfaces
{
	public interface IConfigProvider
	{
		RootConfig GetRootConfig();
		ItunesConfig GetItunesConfig();
	}
}