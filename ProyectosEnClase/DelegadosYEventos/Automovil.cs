using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    public delegate int SinCombustible(int combustible);
    public class Automovil
    {
        private int litro;
        private int kilometraje;
        private int autonomia;
        private SinCombustible sinCombust;
        //public event SinCombustible SinCombustible;
        SinCombustible sinCombuu;
        public Automovil()
        {

        }

        public Automovil(int litro, int kilometraje) : this()
        {
            this.Litro = litro;
            this.Kilometraje = kilometraje;
        }
        #region propiedades
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

        public void SinCombustibleDelegadoAsigno(SinCombustible sinCombu)
        {
            sinCombust = sinCombu;
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
        #endregion

        public void Andar(int kilometro)
        {
            while (kilometro != 0 && Litro > 0)
            {
                kilometro--;
                Kilometraje++;
                Litro--;
                if (Litro == 0)
                {

                    sinCombust(Litro);
                    Console.WriteLine("Te quedaste sin naftovich yo te aviseee"); //acciono el evento
                }
                EnciendeReserva();
                
            }
        }
        public void EnciendeReserva()
        {
            if (Litro < 10)
            {
                Console.WriteLine("Desea cargar nafta? Y or N");
                if (Console.ReadLine() == "Y")
                {
                    CargarNafta();
                }
                else
                {
                    Console.WriteLine("Queda poca nasta amigo! Cargale un poco no seas rata...");
                }
                
            }
        }
        public int SinCombustiblee(int combust)
        {
            if (Litro == 0)
            {
                return combust;
            }
            return 123;
        }
        public void CargarNafta()
        {
            int litrosACargar = 0;
            Console.WriteLine("Ingrese la cantidad de litros que desea cargar");
            Console.ReadLine();
            Cargar = litrosACargar;
        }

    }
}
