using Galindo_Fernando_primera_aplicación_web.Models;

namespace Galindo_Fernando_primera_aplicación_web.Repositorio
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
            };

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona SC",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
            };

            Equipo independiente = new Equipo
            {
                Id = 3,
                Nombre = "Independiente del Valle",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 2,
                PartidosPerdidos = 0,
            };

            Equipo aucas = new Equipo
            {
                Id = 4,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
            };

            Equipo emelec = new Equipo
            {
                Id = 5,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
            };

            Equipo ucatolica = new Equipo
            {
                Id = 6,
                Nombre = "U. Católica",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 4,
                PartidosPerdidos = 1,
            };

            Equipo delfin = new Equipo
            {
                Id = 7,
                Nombre = "Delfín",
                PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
            };

            Equipo tecnico = new Equipo
            {
                Id = 8,
                Nombre = "Técnico Universitario",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3,
            };

            Equipo nacional = new Equipo
            {
                Id = 9,
                Nombre = "El Nacional",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
            };

            Equipo orense = new Equipo
            {
                Id = 10,
                Nombre = "Orense",
                PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 5,
            };

            Equipo cuenca = new Equipo
            {
                Id = 11,
                Nombre = "Deportivo Cuenca",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 5,
            };

            Equipo libertad = new Equipo
            {
                Id = 12,
                Nombre = "Libertad",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 6,
            };

            Equipo mushucruna = new Equipo
            {
                Id = 13,
                Nombre = "Mushuc Runa",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 6,
            };

            Equipo imbabura = new Equipo
            {
                Id = 14,
                Nombre = "Imbabura",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 7,
            };

            Equipo cumbaya = new Equipo
            {
                Id = 15,
                Nombre = "Cumbayá",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 7,
            };

            Equipo guayaquilcity = new Equipo
            {
                Id = 16,
                Nombre = "Guayaquil City",
                PartidosJugados = 10,
                PartidosGanados = 0,
                PartidosEmpatados = 3,
                PartidosPerdidos = 7,
            };

            equipos.Add(ldu);
            equipos.Add(bsc);
            equipos.Add(independiente);
            equipos.Add(aucas);
            equipos.Add(emelec);
            equipos.Add(ucatolica);
            equipos.Add(delfin);
            equipos.Add(tecnico);
            equipos.Add(nacional);
            equipos.Add(orense);
            equipos.Add(cuenca);
            equipos.Add(libertad);
            equipos.Add(mushucruna);
            equipos.Add(imbabura);
            equipos.Add(cumbaya);
            equipos.Add(guayaquilcity);

            equipos = equipos.OrderByDesending(item =>item.TotalPuntos).Tolist();

            return equipos; 
        }

        public Equipo DevuelvemeInformacionEquipo(int Id){

            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item => item.ID==Id);

            return equipo;
        }

        public bool ActualizarEquipo(Equipo equipo){
            //Logica para actualizar
            return true;
        }
    }
}