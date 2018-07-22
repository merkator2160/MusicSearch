using MusicSearch.Services.Interfaces;
using System;
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
			var albums = await _searchService.GetGroupAlbumsAsync();
		}
	}
}
