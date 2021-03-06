﻿using MusicSearch.Api;
using MusicSearch.Api.Interfaces;
using MusicSearch.Core.AutoMapper;
using MusicSearch.Core.Cache;
using MusicSearch.Core.Config;
using MusicSearch.Forms;
using MusicSearch.Services;
using MusicSearch.Services.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace MusicSearch
{
	public class MusicSearchApplicationContext : ApplicationContext
	{
		private readonly IUnityContainer _container;


		public MusicSearchApplicationContext()
		{
			_container = GetConfiguredContainer();

			var mainForm = _container.Resolve<AlbumSearchForm>();
			mainForm.Closed += MainFormOnClosed;
			mainForm.Show();
		}


		// HANDLERS /////////////////////////////////////////////////////////////////////////////////////
		private void MainFormOnClosed(Object sender, EventArgs eventArgs)
		{
			ExitThread();
		}


		// FUNCTIONS //////////////////////////////////////////////////////////////////////////////
		private IUnityContainer GetConfiguredContainer()
		{
			var container = new UnityContainer();

			container.RegisterType<AlbumSearchForm>();
			container.RegisterType<IItunesHttpClient, ItunesHttpClient>();
			container.RegisterType<ISearchService, SearchService>();
			container.RegisterType<IConfig, ConfigProvider>();
			container.RegisterType<ICache, RedisCache>();
			container.RegisterInstance(AutoMapperMiddleware.GetConfiguredMapper());

			return container;
		}
	}
}