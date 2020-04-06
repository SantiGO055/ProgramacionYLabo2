using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Player
    {

        //Console.Title="Mi ejemplo jueguito";
        private string name; //atributos de la clase

        public int lifeLevel;
        public int armorLevel;
        public bool isHero;

        private static string info = "INFORMACION EXTRA";

        public static bool ValidarContraseña(string contraseña)
        {

            while (Player.ValidarContraseña(contraseña)){
                return true;
            }
            return false;

        }
        

        public static void MostrarInfoExtra(Player aux)
        {

        }
        public void CambiarNombre(string name)
        {
            this.name = name; //this.name hace referencia al name de private string name
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Info del personaje");

            Console.WriteLine("El nombre de mi personaje es: "+ name);
            Console.WriteLine("La vida actual de mi personaje es: " + lifeLevel);
            Console.WriteLine("El nivel de armadura es: " + armorLevel);
            if (isHero)
            {
                Console.WriteLine("Es un HEROE");
            }
            else
            {
                Console.WriteLine("No es un HEROE");
            }
            //Console.Write(!isHero ? "No es" : "Es" + " un HEROE");
        }

    }
}
