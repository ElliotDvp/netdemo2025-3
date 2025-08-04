using System.ComponentModel.DataAnnotations;

namespace netdemo20252.Models;

public class Sugerencia
{
    [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "La categoría es obligatoria.")]
    public string? Categoria { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    public string? Descripcion { get; set; }
}
