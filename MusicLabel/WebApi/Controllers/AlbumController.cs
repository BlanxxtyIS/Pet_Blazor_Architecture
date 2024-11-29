using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private static readonly Album[] Albums = new[]
        {
            new Album {
                AlbumId = 1,
                AlbumName = "Greatest Hits",
                Description = "A collection of the greatest hits from various artists.",
                Image = "https://example.com/images/greatest-hits.jpg",
                CreatingLocation = "Los Angeles, CA",
                TimeInMinutes = 45,
                Raiting = 5,
                Tracks = new List<Track>
                {
                    new Track { TrackId = 1, Title = "Hit Song One", Text = "This is a description of hit song one." },
                    new Track { TrackId = 2, Title = "Hit Song Two", Text = "This is a description of hit song two." },
                    new Track { TrackId = 3, Title = "Hit Song Three", Text = "This is a description of hit song three." }
                }
            },
            new Album {
                AlbumId = 2,
                AlbumName = "Chill Vibes",
                Description = "Relaxing music for your downtime.",
                Image = "https://example.com/images/chill-vibes.jpg",
                CreatingLocation = "New York, NY",
                TimeInMinutes = 60,
                Raiting = 4,
                Tracks= new List<Track>
                {
                    new Track { TrackId=4, Title="Chill Song One", Text="Description for chill song one."},
                    new Track { TrackId=5, Title="Chill Song Two", Text="Description for chill song two."},
                    new Track { TrackId=6, Title="Chill Song Three", Text="Description for chill song three."}
                }
            },
            new Album {
                AlbumId=3,
                AlbumName="Rock Classics",
                Description="Timeless rock anthems that defined generations.",
                Image="https://example.com/images/rock-classics.jpg",
                CreatingLocation="Seattle, WA",
                TimeInMinutes=50,
                Raiting=5,
                Tracks=new List<Track>
                {
                    new Track{TrackId=7, Title="Classic Rock One", Text="Description for classic rock one."},
                    new Track{TrackId=8, Title="Classic Rock Two", Text="Description for classic rock two."},
                    new Track{TrackId=9, Title="Classic Rock Three", Text="Description for classic rock three."}
                }
            }
        };

        [HttpGet(Name = "GetMusicAlbums")]
        public IEnumerable<Album> Get()
        {
            return Albums;
        }

        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }
    }
}
