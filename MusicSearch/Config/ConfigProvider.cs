using MusicSearch.Config.Interfaces;
using MusicSearch.Config.Models;

namespace MusicSearch.Config
{
	public class ConfigProvider : IConfigProvider
	{
		private static readonly RootConfig _rootConfig;


		static ConfigProvider()
		{
			_rootConfig = new RootConfig()
			{
				ItunesConfig = new ItunesConfig()
				{
					ItunesApiSearchUri = "https://itunes.apple.com/search",
					ItunesApiLookupUri = "https://itunes.apple.com/lookup"
				}
			};
		}


		// IConfigProvider ////////////////////////////////////////////////////////////////////////
		public RootConfig GetRootConfig()
		{
			return _rootConfig;
		}
		public ItunesConfig GetItunesConfig()
		{
			return _rootConfig.ItunesConfig;
		}
	}
}