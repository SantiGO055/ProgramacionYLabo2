using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47Generics
{
    public class Torneo<T> where T : Equipo
    {
        string nombre;
        List<T> equipos;
        
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get { return CalcularPartido(ObtenerNumeroRandomEquipo(equipos), ObtenerNumeroRandomEquipo(equipos)); }
        }
        private T ObtenerNumeroRandomEquipo(List<T> equipos)
        {
            Random randomLista = new Random();
            int i;
            i = randomLista.Next(equipos.Count);
            return equipos[i];
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            return torneo.equipos.Contains(equipo);
        }
        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public static bool operator +(T equipo, Torneo<T> torneo)
        {
            if (!(torneo == equipo))
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Torneo: " + nombre);
            
            foreach (var item in equipos)
            {
                sb.AppendLine("Nombre: " + item.Nombre);
                sb.AppendLine("Fecha de creacion: " + item.FechaCreacion);
            }
            
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            var numeroRandomEquipo1 = new Random();
            var numeroRandomEquipo2 = new Random();
            numeroRandomEquipo1.Next(0, 5);
            numeroRandomEquipo2.Next(0, 5);
            return equipo1.Nombre + numeroRandomEquipo1.ToString() + " -- " + equipo2.Nombre + numeroRandomEquipo2.ToString();
        }
    }
}
