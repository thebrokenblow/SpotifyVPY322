using Microsoft.AspNetCore.Mvc;
using SpotifyVPY322.Repositories.Interfaces;

namespace SpotifyVPY322.Controllers;

public class ArtistController(IArtistRepository artistRepository) : Controller
{
    public IActionResult Index()
    {
        var artists = artistRepository.GetAllAsync();

        return View(artists);
    }

    public IActionResult Details(int id)
    {
        var detailsArtist = artistRepository.GetDetailsAsync(id);

        return View(detailsArtist);
    }
}
