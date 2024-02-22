
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjapru
{

    public class Animal
    {
       public  string nombre;
       public string sonido;
       public  string tipo;
       public string estado;

        public virtual void Nombrar(string newName)
        {
            nombre = newName;
        }

        public virtual string Sonido()
        {
            return sonido;
        }
        public virtual string Tipo()
        {
            return tipo;
        }

        public virtual string Estado()
        {
            return estado;
        }



    }

}
