using System.Collections.ObjectModel;

namespace The_Music_of_Des_Rocs.Models
{
    public class Album : ObservableCollection<Song>
    {
        public string Name { get; set; }
        public string Note { get; set; }

        public string Cover { get; set; }

        public Album(string name, string note, string cover, ObservableCollection<Song> songs) : base(songs)
        {
            Name = name;
            Note = note;
            Cover = cover;
        }
    }
}