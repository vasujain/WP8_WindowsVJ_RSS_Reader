// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of LatestPosts_News ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class LatestPosts_NewsViewModel : BindableBase, ILatestPosts_NewsViewModel
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ILockScreenService _lockScreenService;
		private readonly IRSSDataSource _rSSDataSource;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestPosts_NewsViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="rSSDataSource">The R S S Data Source.</param>
        public LatestPosts_NewsViewModel(IDialogService dialogService, INavigationService navigationService, ILockScreenService lockScreenService, IRSSDataSource rSSDataSource)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_rSSDataSource = rSSDataSource;
        }
		

		private ObservableCollection<RssSearchResult> _latestPosts_NewsListControlCollection;

        /// <summary>
        /// LatestPosts_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<RssSearchResult> LatestPosts_NewsListControlCollection
        {
            get
            {
                if(_latestPosts_NewsListControlCollection == null)
					RefreshLatestPosts_NewsListControlCollectionDelegate();
				return _latestPosts_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _latestPosts_NewsListControlCollection, value);
            }
        }

		private RssSearchResult _selectedLatestPosts_NewsListControlCollection;

        /// <summary>
        /// SelectedLatestPosts_NewsListControlCollection property.
        /// </summary>		
        public RssSearchResult SelectedLatestPosts_NewsListControlCollection
        {
            get
            {
				return _selectedLatestPosts_NewsListControlCollection;
            }
            set
            {
                _selectedLatestPosts_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IAboutUsViewModel>(_selectedLatestPosts_NewsListControlCollection);
            }
        }

		private MenuItemData _selectedMenuSection_MenuMenuControl;

        /// <summary>
        /// SelectedMenuSection_MenuMenuControl property.
        /// </summary>		
        public MenuItemData SelectedMenuSection_MenuMenuControl
        {
            get
            {
				return _selectedMenuSection_MenuMenuControl;
            }
            set
            {
                _selectedMenuSection_MenuMenuControl = value;
                if (value != null)
                    _navigationService.NavigateTo(value);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshLatestPosts_NewsListControlCollection command.
        /// </summary>
        public async void RefreshLatestPosts_NewsListControlCollectionDelegate(int pageNumber= 1) 
        {
			try
			{
				LoadingLatestPosts_NewsListControlCollection = true;
				LatestPosts_NewsListControlCollection = await _rSSDataSource.GetData();
			}
            catch (Exception ex)
            {
				LatestPosts_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(AppResources.rssError + Environment.NewLine + AppResources.TryAgain);
            }
            finally
            {
				LoadingLatestPosts_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingLatestPosts_NewsListControlCollection;
		
        public bool LoadingLatestPosts_NewsListControlCollection
        {
            get { return _loadingLatestPosts_NewsListControlCollection; }
            set { SetProperty(ref _loadingLatestPosts_NewsListControlCollection, value); }
        }

        private ICommand _refreshLatestPosts_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshLatestPosts_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshLatestPosts_NewsListControlCollection
        {
            get { return _refreshLatestPosts_NewsListControlCollection = _refreshLatestPosts_NewsListControlCollection ?? new DelegateCommand<int>(RefreshLatestPosts_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
	
				_lockScreenService.SetLockScreen("LockScreen-Generic-01.png");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new DelegateCommand(SetLockScreenCommandDelegate); }
        }
    }
}