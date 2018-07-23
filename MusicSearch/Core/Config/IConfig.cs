using MusicSearch.Core.Config.Models;

namespace MusicSearch.Core.Config
{
	public interface IConfig
	{
		RootConfig GetRootConfig();
		ItunesConfig GetItunesConfig();
	}
}