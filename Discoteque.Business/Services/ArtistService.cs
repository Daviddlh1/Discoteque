using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Service;

public class ArtistService : IArtistService
{
    public Task<Artist> CreateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        var list = new List<Artist>();
        for (int i = 1; i <= 5; i++) {
            list.Add(new Artist()
            {
                Id = Random.Shared.Next(1, 1000),
                Name = $"Master {i}",
                Label = "EMI {i}",
                IsOntour = true
            });
        }
        return Task.FromResult(list as IEnumerable<Artist>);
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}