using System;

namespace Clase4
{
    //Debemos realizar la carga de 5(cinco) productos de prevención de contagio,
    //de cada una debo obtener los siguientes datos:
    //el tipo(validar "barbijo" , "jabón" o "alcohol") ,
    //el precio(validar entre 100 y 300),
    //la cantidad de unidades(no puede ser 0 o negativo y no debe superar las 1000 unidades), 
    // la Marca
    //y el fabricante.

    public class Producto
    {
        public string tipo;
        public int cantidad;
        public float precio;
        public string marca;
        public string fabricante;



        public Producto()
        {
            this.tipo = "DEFECTO TIPO";
            this.precio = 100;
            this.cantidad = 1;
            this.marca = "MARCA MARCA";
            this.fabricante = "FABRI FABRICA";
        }
        public Producto(string tipo) : this() //esto se llama sobrecarga de constructores
        {
            this.tipo = tipo;
        }
        public Producto(string tipo, float precio) : this(tipo) //esto se llama sobrecarga de constructores
        {
            this.tipo = tipo;
            this.precio = precio;
        }
        public Producto(string tipo, float precio, int cantidad) : this(tipo, precio) //esto se llama sobrecarga de constructores
        {
            this.tipo = tipo;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public Producto(string tipo, float precio, int cantidad, string marca) : this(tipo, precio, cantidad) //esto se llama sobrecarga de constructores
        {
            this.tipo = tipo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.marca = marca;
        }
        public Producto(string tipo, float precio, int cantidad, string marca, string fabricante) : this(tipo, precio, cantidad, marca) //constructor de instancia primero se hace el this() y despues lo que esta dentro, se usa para ahorrar codigo
        {

            this.marca = marca;
            this.fabricante = fabricante;
        }
        //CTRL + K + E acomoda todo
        public void IngresarProducto()
        {

            Console.WriteLine("Ingrese el tipo de producto: barbijo / jabon / alcohol");
            tipo = Console.ReadLine();
            while ((tipo != "barbijo" || tipo != "Barbijo") && (tipo != "Jabon" || tipo != "jabon" ||
                tipo != "Jabón" || tipo != "jabón" ) && (tipo != "alcohol" || tipo != "Alcohol"))
            {
                Console.WriteLine("ERROR! Ingrese tipo: ");
                tipo = Console.ReadLine();
            }
            this.tipo = tipo;

            Console.WriteLine("Ingrese precio: ");
            float.TryParse(Console.ReadLine(), out precio);
            while (precio < 100 || precio > 300)
            {
                Console.WriteLine("ERROR! Ingrese precio: ");
                float.TryParse(Console.ReadLine(), out precio);
            }
            this.precio = precio;

            if (cantidad > 0 && cantidad <= 1000)
            {
                this.cantidad = cantidad;
            }
        }
        private string Mostrar(string tx)
        {
            return "hola, mi texto es: " + tx;

        }
        public int Mostrar(string texto, int cant) //esta funcion llama a la de arriba, para ahorrar codigo
        {
            texto = this.Mostrar(texto);

            return cant;
        }
    }
}
