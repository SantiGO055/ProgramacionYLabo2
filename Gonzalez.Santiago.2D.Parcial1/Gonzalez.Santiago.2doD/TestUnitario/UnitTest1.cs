using System;
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
            Alumno a1 = new Alumno("pipi","cucu",0,true,1234,r1,0);

            //Assert.IsNotNull(a1);

        }
        [TestMethod]
        public void PersonaDniInvalido()
        {
            Responsable r1 = new Responsable("pepe", "cucu", 0, false, EParentesco.Padre, "11456789");
            Alumno a1 = new Alumno("pipi","cucu",0,true,1234,r1,0);

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
    }
}
