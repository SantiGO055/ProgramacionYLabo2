using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    public delegate void SinCombustible(int combustible);
    public class Automovil
    {
        private int litro;
        private int kilometraje;
        private int autonomia;

        public event SinCombustible SinCombustible;

        public Automovil()
        {

        }

        public int Litro
        {
            get { return litro; }
            set { litro = value; }
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
            while (kilometro != 0)
            {
                kilometro--;
                Kilometraje++;
                Litro--;
            }
        }
        public void EnciendeReserva()
        {
            if (Litro < 10)
            {
                Console.WriteLine("Queda poca nasta amigo! Cargale un poco no seas rata...");
            }
        }
        public void SinCombustiblee()
        {
            if (Litro == 0)
            {
                Console.WriteLine("Yo te avise hace un rato y no me diste bola, te quedaste sin naftovich");
            }
        }


    }
}
