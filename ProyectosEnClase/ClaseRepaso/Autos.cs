using System.Text;

namespace ClaseRepaso
{
    public class Autos
    {
        private string patente;
        private string marca;
        private int cantPuertas;
        private int dniDueño;

        public Autos(string patente, string marca, int cantPuertas, int dniDueño) : this(patente, dniDueño)
        {
            this.marca = marca;
            this.cantPuertas = cantPuertas;
        }
        public Autos(string patente, int dniDueño) : this()
        {
            this.patente = patente;
            this.dniDueño = dniDueño;
        }
        private Autos()
        {
            this.marca = "DATO NO INGRESADO";
            this.cantPuertas = -1;
        }

        public string GetInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendFormat("Marca: {0}\n", this.marca);

            sb.AppendLine("DNI Dueño: " + this.dniDueño);
            if (this.cantPuertas != -1)
            {
                sb.AppendLine("Cantidad de puertas: " + this.cantPuertas);
            }
            else
            {
                sb.AppendLine("Cantidad de puertas: Dato no ingresado");
            }

            return sb.ToString();
        }

        public void SetInformacion(int cantPuertas)
        {
            this.cantPuertas = cantPuertas;
        }
        public void SetInformacion(string marca)
        {
            this.marca = marca;
        }
        public void SetInformacion(int cantPuertas, string marca)
        {
            this.SetInformacion(cantPuertas, marca);
        }

        public static bool operator ==(Autos autoA, Autos autoB) //un auto es igual a otro por la patente
        {
            //bool iguales = false;
            //if (autoA.patente == autoB.patente)
            //{
            //    iguales = true;
            //}

            //return iguales;
            return autoA.patente == autoB.patente;
        }

        public static bool operator !=(Autos autoA, Autos autoB)
        {
            //bool iguales = true;
            //if (autoA.patente == autoB.patente)
            //{
            //    iguales = false;
            //}

            return !(autoA == autoB); //usamos == por que el codigo de arriba de la sobrecarga del igual igual ya sabe como comparar autos por patente
        }

        public static explicit operator string(Autos autito) //casteo manualmente a string
        {
            return autito.GetInformacion();
        }
        
        
    }
}
