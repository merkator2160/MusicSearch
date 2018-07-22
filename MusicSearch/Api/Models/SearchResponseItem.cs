using System;

namespace MusicSearch.Api.Models
{
	public class SearchResponseItem
	{
		public String WrapperType { get; set; }
		public String Kind { get; set; }
		public Int32 ArtistId { get; set; }
		public Int32 CollectionId { get; set; }
		public Int32 TrackId { get; set; }
		public String ArtistName { get; set; }
		public String CollectionName { get; set; }
		public String TrackName { get; set; }
		public String CollectionCensoredName { get; set; }
		public String TrackCensoredName { get; set; }
		public String ArtistViewUrl { get; set; }
		public String CollectionViewUrl { get; set; }
		public String TrackViewUrl { get; set; }
		public String PreviewUrl { get; set; }
		public String ArtworkUrl60 { get; set; }
		public String ArtworkUrl100 { get; set; }
		public Decimal CollectionPrice { get; set; }
		public Decimal TrackPrice { get; set; }
		public String CollectionExplicitness { get; set; }
		public String TrackExplicitness { get; set; }
		public Int32 DiscCount { get; set; }
		public Int32 DiscNumber { get; set; }
		public Int32 TrackCount { get; set; }
		public Int32 TrackNumber { get; set; }
		public Int64 TrackTimeMillis { get; set; }
		public String Country { get; set; }
		public String Currency { get; set; }
		public String PrimaryGenreName { get; set; }
	}
}