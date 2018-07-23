using MusicSearch.Services.Interfaces;
using MusicSearch.Services.Models;
using System;
using System.Text;
using System.Windows.Forms;

namespace MusicSearch.Forms
{
	public partial class AlbumSearchForm : Form
	{
		private readonly ISearchService _searchService;


		public AlbumSearchForm(ISearchService searchService)
		{
			_searchService = searchService;

			InitializeComponent();
		}


		// HANDLERS ///////////////////////////////////////////////////////////////////////////////
		private async void SearchBtn_Click(Object sender, EventArgs e)
		{
			var albums = await _searchService.GetGroupAlbumsAsync(QueryTb.Text.Trim());

			SearchResultTb.Text = PrepareAlbumsToPrint(albums);
		}


		// FUNCTIONS //////////////////////////////////////////////////////////////////////////////
		private String PrepareAlbumsToPrint(AlbumDto[] albums)
		{
			var stringBuilder = new StringBuilder();

			foreach (var x in albums)
			{
				stringBuilder.AppendLine(x.CollectionName);
			}

			return stringBuilder.ToString();
		}
	}
}