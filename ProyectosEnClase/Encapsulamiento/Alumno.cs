using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{

    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int legajo;
        public Alumno(string nom, string ape, int ed, int leg)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.edad = ed;
            this.legajo = leg;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public static string GetUnNombre(Alumno aux)
        {
            return aux.nombre;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


    }
}
