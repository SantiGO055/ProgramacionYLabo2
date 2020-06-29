using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    public delegate string SinCombustible(string combustible);
    public class Automovil
    {
        private int litro;
        private int kilometraje;
        private int autonomia;

        //public event SinCombustible SinCombustible;
        SinCombustible sinCombuu;
        public Automovil()
        {
            sinCombuu = new SinCombustible(SinCombustiblee);
        }

        public Automovil(int litro, int kilometraje) : this()
        {
            this.Litro = litro;
            this.Kilometraje = kilometraje;
        }
        public int Litro
        {
            get { return litro; }
            set {
                
                litro = value;
            }
        }
        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }
        public int Autonomia
        {
            get { return autonomia; }
            set { autonomia = value; }
        }

        public int Cargar
        {
            get { return Litro; }
            set {
                if (value <= 100)
                {

                    Litro = value;
                }
            }
        }

        public void Andar(int kilometro)
        {
            while (kilometro != 0 && Litro > 0)
            {
                kilometro--;
                Kilometraje++;
                Litro--;
                Console.WriteLine(sinCombuu.Invoke("Queda poca nastaa"));
                Console.WriteLine(sinCombuu.Invoke("Te quedaste sin naftovich amigo"));
            }
        }
        public void EnciendeReserva(string mensajeReserva)
        {
            if (Litro < 10)
            {
                Console.WriteLine("Queda poca nasta amigo! Cargale un poco no seas rata...");
            }
        }
        public string SinCombustiblee(string mensajeSinCombustible)
        {
            if (Litro == 0)
            {
                return mensajeSinCombustible;
            }
            return "Avanzando por km";
        }


    }
}
