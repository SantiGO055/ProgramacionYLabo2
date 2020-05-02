using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Libro
    {
        private List<string> paginas;
        private int index;

        public Libro()
        {
            paginas = new List<string>();
            CargarPagina();
        }

        private void CargarPagina()
        {
            paginas.Add("algo1"); //0
            paginas.Add("algo2"); //1
            paginas.Add("algo3"); //2
            //if (this.paginas[index] == paginas.Count)
            //{

            //}
        }

        public string this[int indice]
        {
            get
            {
                if (indice > 0 && indice <= paginas.Count) //valido que sea un indice valido, mayor a 0 y que no supere la cantidad de indice del libro
                {
                    return this.paginas[indice - 1];
                }
                return string.Empty;

            }
            set
            {
                if (indice >= 0 && indice<= paginas.Count)
                {
                    this.paginas[indice-1] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
