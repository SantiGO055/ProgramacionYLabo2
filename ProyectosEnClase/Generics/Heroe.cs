using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public enum ETipoHeroe
    {
        Guerrero,
        Mago,
        Berserker

    }
    public class Heroe<T,U>
    {
        T vida;
        U cantMana;
        ETipoHeroe tipoHeroe;
        string aux;

        public Heroe(T vida, U mana, ETipoHeroe tipo,string aux)
        {
            this.vida = vida;
            this.cantMana = mana;
            this.tipoHeroe = tipo;
            this.aux = aux;

        }
    }
}
