using MusicSearch.Core.Config;
using MusicSearch.Core.Config.Models;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;

namespace MusicSearch.Core.Cache
{
	public class RedisCache : ICache
	{
		private readonly RedisCacheConfig _config;


		public RedisCache(IConfig configProvider)
		{
			_config = configProvider.GetRedisCacheConfig();
		}


		// ICache /////////////////////////////////////////////////////////////////////////////////
		public void SetObject<T>(String key, T obj)
		{
			SetString(key, JsonConvert.SerializeObject(obj));
		}
		public void SetObject<T>(String key, T obj, TimeSpan expiry)
		{
			SetString(key, JsonConvert.SerializeObject(obj), expiry);
		}
		public void SetString(String key, String str)
		{
			SetString(key, str, TimeSpan.FromSeconds(_config.DafaultExpirySec));
		}
		public void SetString(String key, String str, TimeSpan expiry)
		{
			using(var redis = ConnectionMultiplexer.Connect(_config.ConnectionString))
			{
				var db = redis.GetDatabase();
				db.StringSet(key, str, TimeSpan.FromSeconds(_config.DafaultExpirySec));
			}
		}
		public T GetObject<T>(String key)
		{
			return JsonConvert.DeserializeObject<T>(GetString(key));
		}
		public Boolean TryGetObject<T>(String key, out T obj)
		{
			if (TryGetString(key, out var str))
			{
				obj = JsonConvert.DeserializeObject<T>(GetString(key));
				return true;
			}

			obj = default(T);
			return false;
		}
		public String GetString(String key)
		{
			using(var redis = ConnectionMultiplexer.Connect(_config.ConnectionString))
			{
				var db = redis.GetDatabase();

				return db.StringGet(key);
			}
		}
		public Boolean TryGetString(String key, out String str)
		{
			str = GetString(key);
			return !String.IsNullOrEmpty(str);
		}
	}
}