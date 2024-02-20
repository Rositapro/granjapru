using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjapru
{
    internal class Vaca:Animal
    {

        public Vaca() 
        {
            sonido = "muuu";
            tipo = "terrestre";
            estado = "feliz";
        }

        public override void Nombrar(string newName)
        {
            nombre = newName;
        }
        public override string Sonido()
        {
            return sonido;
        }
        public override string Tipo()
        {
            return tipo; 
        }
        public override string Estado()
        {
            return estado;   
        }

        public override string ToString()
        {
            return "muuuuuucho gusto, me llamo lola" + nombre;
        }
    }
}
