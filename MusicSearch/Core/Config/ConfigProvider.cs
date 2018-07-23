using MusicSearch.Core.Config.Models;

namespace MusicSearch.Core.Config
{
	public class ConfigProvider : IConfig
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
				},
				RedisCacheConfig = new RedisCacheConfig()
				{
					ConnectionString = "localhost",
					DafaultExpirySec = 600
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
		public RedisCacheConfig GetRedisCacheConfig()
		{
			return _rootConfig.RedisCacheConfig;
		}
	}
}