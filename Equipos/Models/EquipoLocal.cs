using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos.Models
{
    public class EquipoLocal : Equipo , IPartido
    {
        public EquipoLocal(string nombre, string entrenador) : base(nombre, entrenador) { }
        
        public string SimularPartido(Equipo equipo1, Equipo equipo2)
        {
            Random rand = new Random();
            int golesEquipo1 = rand.Next(0, 5);
            int golesEquipo2 = rand.Next(0, 5);

            return 
                $"{equipo1.Nombre} {golesEquipo1} - {golesEquipo2} {equipo2.Nombre}";
        }
    }
}
