using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Clases.Abstractas;

namespace ClasesInstanciables
{
    public enum EEstadoCuenta
    {
        AlDia,
        Deudor,
        Becado
    }
    public enum EClase
    {
        Programacion,
        Laboratorio,
        Contabilidad,
        SPD
    }

    public sealed class Alumno : Universitario
    {
        private EClase clasesQueToma;
        private EEstadoCuenta estadoCuenta;
        public Alumno(int legajo, string nombre, string apellido, ENacionalidad nacionalidad, int dni, EClase clasesQueToma) :
            base(legajo,nombre,apellido,nacionalidad,dni)
        {
            this.ClasesQueToma = clasesQueToma;
        }


        public EClase ClasesQueToma
        {
            get { return this.clasesQueToma; }
            set { this.clasesQueToma = value; }
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TOMA CLASE DE: " + ClasesQueToma);
            return sb.ToString();
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ESTADO DE CUENTA: " + estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

    }
}
