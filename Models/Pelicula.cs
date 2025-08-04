using System.ComponentModel.DataAnnotations;

namespace netdemo20252.Models;
public class Pelicula
{
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string ImagenUrl { get; set; } = "";
    public string FechaEstreno { get; set; } = "";
}
