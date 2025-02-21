using Microsoft.EntityFrameworkCore;
using SpotifyVPY322.Data;
using SpotifyVPY322.Dto.Artist;
using SpotifyVPY322.Repositories.Interfaces;

namespace SpotifyVPY322.Repositories;

public class ArtistRepository(SpotifyDataContext context) : IArtistRepository
{
    public async Task<List<GetAllArtistDto>> GetAllAsync()
    {
        return await context.Artists.Select(artist => new GetAllArtistDto
                     {
                        Id = artist.Id,
                        Title = artist.Title,
                        PhotoUrl = artist.PhotoUrl
                     }).ToListAsync();
    }
}