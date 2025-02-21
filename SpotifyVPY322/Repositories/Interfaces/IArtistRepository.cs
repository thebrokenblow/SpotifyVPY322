using SpotifyVPY322.Dto.Artist;

namespace SpotifyVPY322.Repositories.Interfaces;

public interface IArtistRepository
{
    Task<List<GetAllArtistDto>> GetAllAsync();
    Task<GetAllArtistDto> GetDetailsAsync(int id);
}