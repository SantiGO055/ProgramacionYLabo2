using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using FormularioLosPichoncitos;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDniException))]
        public void PersonaSinDni()
        {
            Responsable r1 = new Responsable("pepe", "cucu", 0, false, EParentesco.Padre, "11456789");
            Alumno a1 = new Alumno("pipi", "cucu", 0, true, 1234, r1, 0);

            //Assert.IsNotNull(a1);

        }
        [TestMethod]
        public void PersonaDniInvalido()
        {
            Responsable r1 = new Responsable("pepe", "cucu", 0, false, EParentesco.Padre, "11456789");
            Alumno a1 = new Alumno("pipi", "cucu", 0, true, 1234, r1, 0);

            //Assert.IsNotNull(a1);

        }

        [TestMethod]
        public void PersonaDniValido()
        {
            Responsable r1 = new Responsable("pepe", "cucu", 2000000, false, EParentesco.Padre, "11456789");
            Alumno a1 = new Alumno("pipi", "cucu", 2000000, true, 1234, r1, 0);

            Assert.IsNotNull(a1);

        }
        [TestMethod]
        public void CrearDocenteYAlumnosAutomaticamente()
        {
            FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
            frmPrincipal.CrearAlumnosAutomaticamente();

            Assert.IsTrue(frmPrincipal.listaDocentes.Count == 5 && frmPrincipal.listaAlumnos.Count == 50);


        }

        [TestMethod]
        public void PruebaInterface()
        {
            //List<IMensaje> listaMensaje = new List<IMensaje>();
            Docente d1 = new Docente("Pepe", "Gonzalez", 123654872, false, Convert.ToDateTime("1/2/2000 11:30:00 AM"), Convert.ToDateTime("1/2/2000 11:30:00 AM"), 200);
            Docente d2 = new Docente("Maria", "Rodriguez", 123652134, true, Convert.ToDateTime("1/2/2000 9:30:00 AM"), Convert.ToDateTime("1/2/2000 11:30:00 AM"), 200);
            Docente d3 = new Docente("Juan", "Perez", 23658749, false, Convert.ToDateTime("1/2/2000 8:30:00 AM"), Convert.ToDateTime("1/2/2000 11:30:00 AM"), 200);
            Docente d4 = new Docente("Rodrigo", "De la Serna", 46875123, false, Convert.ToDateTime("1/2/2000 7:30:00 AM"), Convert.ToDateTime("1/2/2000 11:30:00 AM"), 200);
            Docente d5 = new Docente("Rodrigo", "De la Serna", 46875123, false, Convert.ToDateTime("1/2/2000 7:30:00 AM"), Convert.ToDateTime("1/2/2000 11:30:00 AM"), 200);
            //listaMensaje.Add(d1);
            //listaMensaje.Add(d2);
            //listaMensaje.Add(d3);
            //listaMensaje.Add(d4);
            //listaMensaje.Add(d5);

            string salida = "";

            //foreach (IMensaje item in listaMensaje)
            //{
            //    salida += item.MostrarMensaje();
            //}
            //Assert.IsTrue(salida.Length > 200);

        }
    }
}
