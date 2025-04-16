using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Galindo_Fernando_primera_aplicación_web.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0,20)]
        
        public int PartidosJugados {  get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int TotalPuntos { 
            get{
                int total_puntos = PartidosGanados * 3 + PartidosEmpatados;
                return total_puntos;
            } 
        }

    }
}

