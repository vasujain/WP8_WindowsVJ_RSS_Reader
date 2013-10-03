// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using WPAppStudio.Ioc;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Container();
        }

        /// <summary>
        /// Gets the reference to a LatestPosts_NewsViewModel.
        /// </summary>
		public ILatestPosts_NewsViewModel LatestPosts_NewsViewModel
        {
            get { return _container.Resolve<LatestPosts_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a AboutUsViewModel.
        /// </summary>
		public IAboutUsViewModel AboutUsViewModel
        {
            get { return _container.Resolve<AboutUsViewModel>(); }
        }
    }
}