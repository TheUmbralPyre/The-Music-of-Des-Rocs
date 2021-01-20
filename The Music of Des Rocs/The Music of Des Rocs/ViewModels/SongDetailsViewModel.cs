using Prism.Commands;
using Prism.Navigation;
using The_Music_of_Des_Rocs.Models;
using Xamarin.Essentials;

namespace The_Music_of_Des_Rocs.ViewModels
{
    public class SongDetailsViewModel : ViewModelBase
    {
        private Song selectedSong;
        public Song SelectedSong
        {
            get { return selectedSong; }
            set { SetProperty(ref selectedSong, value); }
        }

        public DelegateCommand OpenSongOnYoutube { get; set; }
        public DelegateCommand OpenSongOnSpotify { get; set; }

        public SongDetailsViewModel(INavigationService _navigationService)
            : base(_navigationService)
        {
            OpenSongOnYoutube = new DelegateCommand(OpenSongOnYoutubeMethod);
            OpenSongOnSpotify = new DelegateCommand(OpenSongOnSpotifyMethod);
        }

        public override void Initialize(INavigationParameters parameters)
        {
            SelectedSong = parameters.GetValue<Song>("SelectedSong");
        }

        private async void OpenSongOnYoutubeMethod()
        {
            await Launcher.OpenAsync(SelectedSong.LinkYoutube);
        }

        private async void OpenSongOnSpotifyMethod()
        {
            await Launcher.OpenAsync(SelectedSong.LinkSpotify);
        }
    }
}
