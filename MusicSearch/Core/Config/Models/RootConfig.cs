namespace MusicSearch.Core.Config.Models
{
	public class RootConfig
	{
		public ItunesConfig ItunesConfig { get; set; }
		public RedisCacheConfig RedisCacheConfig { get; set; }
	}
}