using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUsuario
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contraseñaUsuario;
        public int nivelAcceso;
        public bool estaLogueado;


        public void MostrarInfoUsuario()
        {

        }

        public void CrearUsuario()
        {
            string usuario;
            string contraseña;
            Console.Write("Crear nuevo usuario \n");

            Console.Write("Ingrese usuario");
            usuario = Console.ReadLine();
            while (Usuario.ValidarSiCadenaEsInvalida(usuario))
            {
                Console.WriteLine("Reingrese USUARIO");
                usuario = Console.ReadLine();
            }

            Console.Write("Ingrese contraseña");
            contraseña = Console.ReadLine();
            while (Usuario.ValidarSiCadenaEsInvalida(contraseña))
            {
                Console.WriteLine("Reingrese CONTRASEÑA");
                contraseña = Console.ReadLine();
            }
            this.nombreUsuario = usuario;
            this.contraseñaUsuario = contraseña;
            this.estaLogueado = true;
        }
        public static bool ValidarSiCadenaEsInvalida(string cadena)
        {
            return String.IsNullOrEmpty(cadena);
        }
    }
}
