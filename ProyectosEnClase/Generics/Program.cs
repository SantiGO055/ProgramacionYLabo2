using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Heroe<string,int> miHeroe = new Heroe<string,int>("Esta llena", 200, ETipoHeroe.Guerrero,"asd");
            Heroe<int,string> miHeroe2 = new Heroe<int, string>(80, "No tiene mana", ETipoHeroe.Guerrero,"asd");
        
        }
    }
}
