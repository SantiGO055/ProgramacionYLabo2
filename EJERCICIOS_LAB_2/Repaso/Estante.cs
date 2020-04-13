using System.Linq;
using System.Text;

namespace Repaso
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] arrayDeProductos;

        private Estante(int capacidad)
        {
            arrayDeProductos = new Producto[capacidad];  //el tamaño que tendra el array, el new es del array y no de la clase Auto
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return arrayDeProductos;
        }

        public string MostrarEstante(Estante est)
        {
            string auxProducto;
            StringBuilder sb = new StringBuilder();
            foreach (Producto auxProd in est.arrayDeProductos)
            {
                sb = sb.Append(Producto.MostrarProducto(auxProd));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante est, Producto prod)
        {
            return est.arrayDeProductos.Contains(prod);

            //buscar si el producto esta en el estante mediante el array de productos
            //bool esta = false;
            //for (int i = 0; i < est.arrayDeProductos.Length; i++)
            //{
            //    if (!(est.arrayDeProductos[i] is null))
            //    {
            //        if (est.arrayDeProductos[i] == prod)
            //        {
            //            esta = true;
            //        }

            //    }
            //}
            //return esta;
        }
        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        public static bool operator +(Estante est, Producto prod)
        {
            bool agrego = false;
            if (est != prod) //si no hay ningun producto en el estante
            {
                for (int i = 0; i < est.arrayDeProductos.Length; i++)
                {
                    if (est.arrayDeProductos[i] is null) // si hay lugar
                    {
                        est.arrayDeProductos[i] = prod; //agrego el producto adentro del estante
                        agrego = true;
                        break;
                    }
                }
            }
            return agrego;
        }

        public static Estante operator -(Estante est, Producto prod)
        {
            Estante estAux = new Estante(1);
            //si el producto esta en el estante
            {
                for (int i = 0; i < est.arrayDeProductos.Length; i++)
                {
                    if (!(est.arrayDeProductos[i] is null) && (est == prod)) // si esta ocupado y ese estante contiene el producto
                    {
                        est.arrayDeProductos[i] = null;
                        estAux = est; //agrego el producto adentro del estante
                        break;
                    }
                }
            }
            return estAux;

        }
    }
}
