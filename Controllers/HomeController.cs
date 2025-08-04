using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netdemo20252.Models;

namespace netdemo20252.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Registrar(Sugerencia sugerencia)
    {
    if (!ModelState.IsValid)
    {
        return View("Privacy", sugerencia);
    }
    return View("Gracias");
}
    private static List<Pelicula> peliculas = new List<Pelicula>
        {
            new Pelicula { Id = 1, Titulo = "Progeny", Categoria = "Accion", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSVZl3fyM_oEOG0T16RCwkp2BEVv2Wzyxd9zw&s", FechaEstreno = "28 oct 2025" },
            new Pelicula { Id = 2, Titulo = "Minecraft", Categoria = "Comedia", ImagenUrl = "https://xl.movieposterdb.com/25_05/2025/3566834/xl_a-minecraft-movie-movie-poster_d831add0.jpg", FechaEstreno = "4 abril 2025" },
            new Pelicula { Id = 3, Titulo = "Relative Danger", Categoria = "Accion", ImagenUrl = "https://www.studiotf1america.com/wp-content/uploads/2025/07/55720_RELATIVE_DANGER-scaled.jpg", FechaEstreno = "19 sep 2025" },
            new Pelicula { Id = 4, Titulo = "Trust Her If You Dare", Categoria = "Accion", ImagenUrl = "https://www.studiotf1america.com/wp-content/uploads/2025/07/trust.png", FechaEstreno = "29 ago 2025" },
            new Pelicula { Id = 5, Titulo = "La otra boda", Categoria = "Comedia", ImagenUrl = "https://media.filmelier.com/images/tit/28797/poster/youre-cordially-invited11286.webp", FechaEstreno = "27 ago 2025" },
            new Pelicula { Id = 6, Titulo = "Tierras Perdidas", Categoria = "Accion", ImagenUrl = "https://hips.hearstapps.com/hmg-prod/images/tierras-perdidas-67ea90c60f4ce.jpg?crop=1xw:1xh;center,top&resize=980:*", FechaEstreno = "25 ago 2025" },
            new Pelicula { Id = 7, Titulo = "My Oxford year", Categoria = "Comedia", ImagenUrl = "https://media.themoviedb.org/t/p/w300_and_h450_bestv2/jrhXbIOFingzdLjkccjg9vZnqIp.jpg", FechaEstreno = "23 ago 2025" },
            new Pelicula { Id = 8, Titulo = "Twilig", Categoria = "Romance", ImagenUrl = "https://media.themoviedb.org/t/p/w300_and_h450_bestv2/3Gkb6jm6962ADUPaCBqzz9CTbn9.jpg", FechaEstreno = "18 ago 2025" },
            new Pelicula { Id = 9, Titulo = "Thunderbols", Categoria = "Accion", ImagenUrl = "https://hips.hearstapps.com/hmg-prod/images/thunderbolts-67640c8b27991.jpg?crop=1xw:1xh;center,top&resize=980:*", FechaEstreno = "17 ago 2025" },
            new Pelicula { Id = 10, Titulo = "Prey for the Bride", Categoria = "Terror", ImagenUrl = "https://pics.filmaffinity.com/prey_for_the_bride-824647344-mmed.jpg", FechaEstreno = "14 ago 2025" }
        };

        public IActionResult Index(string categoria)
        {
            var lista = string.IsNullOrEmpty(categoria)
                ? peliculas
                : peliculas.Where(p => p.Categoria == categoria).ToList();

            ViewBag.CategoriaSeleccionada = categoria;
            return View(lista);
        }

    public IActionResult Privacy()
    {
        return View(new Sugerencia());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
