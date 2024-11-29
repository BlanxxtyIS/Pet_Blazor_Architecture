using MusicLabel.Models;
using System.Net.Http.Json;

namespace MusicLabel.Services
{
    public class AlbumService
    {
        private readonly HttpClient _httpClient;

        public AlbumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Album>> GetAlbumsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Album>>("api/album");
        }
    }
}
