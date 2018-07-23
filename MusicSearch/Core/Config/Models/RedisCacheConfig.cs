using System;

namespace MusicSearch.Core.Config.Models
{
	public class RedisCacheConfig
	{
		public String ConnectionString { get; set; }
		public Int32 DafaultExpirySec { get; set; }
	}
}