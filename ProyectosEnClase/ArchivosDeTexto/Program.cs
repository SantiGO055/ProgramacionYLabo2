using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Exists(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\pruebita.txt");
            //Directory.Delete(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\pruebita.txt");

            string [] arrayDirectorio = Directory.GetFiles(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\","prueb*.*");


            using (StreamWriter sw = new StreamWriter(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\pruebita.txt"))
            {
                sw.Write("Este es el ");
                sw.WriteLine("Encabezado para el archivo");
                sw.WriteLine("--------------------------");

                sw.Write("La fecha es: ");
                sw.WriteLine(DateTime.Now);

            }
            //modifico el archivo
            using (StreamWriter sw = new StreamWriter(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\pruebita.txt",true))
                //en el append true si modifico archivo y false para reemplazarlo
            {
                sw.Write("Este es el ");
                sw.WriteLine("archivo modificado");
                sw.WriteLine("--------------------------");

                sw.Write("La fecha es: ");
                sw.WriteLine(DateTime.Now);

            }
            //leo un archivo
            using (StreamReader sr = new StreamReader(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ArchivosDeTexto\pruebita.txt"))
                //en el append true si modifico archivo y false para reemplazarlo
            {
                string line;

                while((line = sr.ReadLine()) != null) //el enter no es un null
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
                
            }



        }
    }
}
