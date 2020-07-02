using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //serializa todo lo publico si es propiedad o atributo publico
            /*
              Para distintos tipos de datos en un mismo programa conviene utilizar generics 
              para no hacer fragmento de codigo para cada objeto 
              Tambien se podra hacer [XmlInclude(typeof(Dato))] donde dato hereda de clase base, si son varias clases
              En serializacion binaria debe estar el tag [Serializable] en la clase que se serializara, serializa atributos publicos o privados

              En los dos casos debera tener ctor vacio sino no lo serializara

             */
            Dato p = new Dato("Pepe",20);
            string FILE_NAME = AppDomain.CurrentDomain.BaseDirectory + "TestFile.xml";
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(FILE_NAME, Encoding.UTF8))
                {

                    XmlSerializer ser = new XmlSerializer(typeof(Dato)); //object sera el tipo de dato a serializar, por ej, alumno, persona, docente
                    ser.Serialize(writer, p); //le paso el serializer y el objeto, lo serializo para que se guarde el objeto en el xml

                }

                //al deserializar debera ser el mismo nombre de la entidad del xml al del objeto a deserializar

                Dato aux;
                using (XmlTextReader reader = new XmlTextReader(FILE_NAME))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    aux = (Dato)ser.Deserialize(reader);

                    Console.Write(aux.edad);
                    Console.Write(aux.nombre);
                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
