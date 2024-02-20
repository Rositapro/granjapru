using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjapru
{
    internal class Gallina:Animal
    {
        public Gallina()
        {
            sonido = "cua cua";
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
            return " cuak mucho gusto, me llamo turuleca " + nombre;
        }
    }
}
