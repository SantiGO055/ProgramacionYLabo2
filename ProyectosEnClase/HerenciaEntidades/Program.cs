using System;
using System.Collections.Generic;

namespace HerenciaEntidades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Profesor pr = new Profesor("profe1");
            Persona persona = new Alumno("alumno1");

            List<Persona> personaCurso = new List<Persona>();

            personaCurso.Add(pr);
            personaCurso.Add(persona);

            if (pr is Profesor)
                ((Profesor)pr).CodigoMateria = 25;



        }
        
    }
}
