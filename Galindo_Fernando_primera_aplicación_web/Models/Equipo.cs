using System.ComponentModel.DataAnnotations;

namespace Galindo_Fernando_primera_aplicación_web.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Nombre del Equipo")]
        public string Nombre { get; set; }
        [Range(0,20)]
        [Display(Name = "Ingrese la cantidad de Partidos Jugados")]
        public int PartidosJugados {  get; set; }
        [Display(Name = "Partidos Ganados")]
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Display(Name = "Partidos Empatados")]
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Display(Name = "Partidos Perdidos")]
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int TotalPuntos {
            get{
                return PartidosGanados * 3 + PartidosEmpatados;
            }
        }
        public ICollection<Jugador> Jugadores { get; set; } = new List<Jugador>();
    }
}