using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using The_Music_of_Des_Rocs.Models;

namespace The_Music_of_Des_Rocs.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Album> albums = new ObservableCollection<Album>();
        public ObservableCollection<Album> Albums
        {
            get { return albums; }
            set { SetProperty(ref albums, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Albums.Add(new Album("Let the Vultures In", "Where it all began...", 
                "https://t2.genius.com/unsafe/862x0/https%3A%2F%2Fimages.genius.com%2Fde57d34b253463fac927b1d22f52098e.268x268x1.jpg", 
                new ObservableCollection<Song>()
            {
                new Song()
                {
                    Name = "Let Me Live / Let Me Die",
                    Note = "You Live as a Vault Hunter, you Die as a Vault Hunter",
                    Lyrics = "[Intro]\nHey!\nHey!\n[Verse 1]\nI know pain, I know dread\nLook his eyes, they've turned to lead\nThe tears don't stop the fire\nIt's killing time\n[Verse 2]\nBack from the dead\nSee your eyes, got nothing left\nKiss me, I am the cobra\nIt's killing time\n[Chorus]\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\n[Verse 3]\nAm I here, am I right?\nWith a name that I never liked\nRip me out the moment\nIt's killing time\n[Verse 4]\nFear in the dark\nOh, these thoughts, yeah, they'll never stop\nMeet my friend, the lonesome\nIt's killing time\n[Chorus]\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\n[Bridge]\nOoh\nOoh, ooh\nForever\nOoh, ooh, ooh, whoa\nWhoa, oh, oh\nDo it again!\n[Chorus]\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die\nOh, let me live, oh, let me live, oh, let me die",
                    Cover = "https://images.genius.com/8d3621735c420581f3683cc7c86c675a.500x500x1.jpg",
                    LinkSpotify = "https://open.spotify.com/track/6ckVL9k9M43EKpeXwASuf6?si=oaRAWM7VScKuRblrsVD_nQ",
                    LinkYoutube = "https://www.youtube.com/watch?v=Ozo8LyvS4fE"
                },
                new Song()
                {
                    Name = "Used to the Darkness",
                    Note = "We are all...",
                    Lyrics = "\n[Verse 1]\nI've made mistakes, the Lord struck me down\nCaught in a landslide, lost underground\nI hear them gates, swing open loud\nCome close to midnight, hell fade me down\n[Pre-Chorus]\nAnd then my eyes got used to the darkness\nAnd everyone that I knew\nWas lost and so long forgotten after you\n[Chorus]\nNow would you pray before you twist the knife?\nYeah, would you take my hand and take a life?\nI'm too damn young to give up on the light\nI'm used to the darkness, I'm used to the darkness\n(Hey)\nI'm just a man, I'm only flesh and bone\nI can't bring it back on everything I've done\nAnd now there's no one else left to love\nI'm used to the darkness, I'm used to the darkness\n(Hey)\n[Verse 2]\nSweet smell of roses, have come at last\nOne fist of Earth fights, to come join the rest, rest, rest\n[Pre-Chorus]\nAnd then my eyes got used to the darkness\nAnd everyone I knew\nWas lost and so long forgotten after you\n[Chorus]\nNow, would you pray before you twist the knife?\nYeah, would you take my hand and take a life?\nI'm too damn young to give up on the light\nI'm used to the darkness\n(Used to the darkness)\nI'm used to the darkness\n(Used to the darkness)\nI'm just a man, I'm only flesh and bone\nI can't bring it back on everything I've done\nAnd now there's no one else left to love\nI'm used to the darkness\n(Used to the darkness)\nI'm used to the darkness\n(Used to the darkness)\n[Bridge]\nI got used to the darkness, too\nI got used to the darkness for you\nI got used to the darkness, too\nYes, I did\n[Chorus]\nWould you pray before you twist the knife?\nWould you take my hand and take a life?\nI'm too damn young to give up on the light\nI'm used to the darkness, I'm used to the darkness\nI'm just a man, I'm only flesh and bone\n(Flesh and bone)\nI can't bring it back on everything I've done\n(Thing I've done)\nAnd now there's no one else left to love\n(Left to love)\nI'm used to the darkness\n(Used to the darkness)\nI'm used to the darkness\n(Used to the darkness)\n[Outro]\nNa, na, na, na, na, na, na, na, na\nNa, na, na, na, na, na, na, na, na\nNa, na, na, na, na, na, na, na, na\nUsed to the darkness\n(Used to the darkness)\nI'm used to the darkness, hey",
                    Cover = "https://images.genius.com/7aec590dc76ed78c19a60629da55a932.700x700x1.jpg",
                    LinkSpotify = "https://open.spotify.com/track/6fLKwF2FLBtPNvtrVjYDVz?si=fykPub5OQ4SgZuPQQqVr9g",
                    LinkYoutube = "https://www.youtube.com/watch?v=7MrRi-2nokM"
                }
            }));
        }
    }
}