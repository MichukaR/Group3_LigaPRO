using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galindo_Fernando_primera_aplicación_web.Models;

public class Jugador
{
    [Key]
    public int JugadorId { get; set; } 
    [Required]
    [MaxLength(50)]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; }
    [MaxLength(50)]
    [Display(Name = "Posicion en la que juega")]
    public string Posiciion { get; set; }
    [ForeignKey("Equipo")] 
    public int EquipoId { get; set; }
    public Equipo Equipo { get; set; }
}