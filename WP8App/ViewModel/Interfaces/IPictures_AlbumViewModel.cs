// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Pictures_Album ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IPictures_AlbumViewModel
    {		
        /// <summary>
        /// Gets/Sets the Pictures_AlbumListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.FlickrSearchResult> Pictures_AlbumListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedPictures_AlbumListControlCollection property.
        /// </summary>
		EntitiesBase.FlickrSearchResult SelectedPictures_AlbumListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Youtube_VideosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> Youtube_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Youtube_VideosListControlCollectionPageNumber property.
        /// </summary>
		int Youtube_VideosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedYoutube_VideosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedYoutube_VideosListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshPictures_AlbumListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshPictures_AlbumListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetPictures_AlbumListControlCollectionCommand command.
        /// </summary>
		ICommand GetPictures_AlbumListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshYoutube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshYoutube_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetYoutube_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand GetYoutube_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}