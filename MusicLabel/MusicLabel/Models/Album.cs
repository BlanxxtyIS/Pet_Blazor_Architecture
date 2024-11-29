namespace MusicLabel.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Image { get; set; } = default!;
        public string CreatingLocation { get; set; } = default!;
        public int TimeInMinutes { get; set; }
        public string TimeFormatted => $"{TimeInMinutes / 60}h {TimeInMinutes % 60}m";
        public int Raiting { get; set; }
        public IEnumerable<Track> Tracks { get; set; } = Array.Empty<Track>();
    }
}
