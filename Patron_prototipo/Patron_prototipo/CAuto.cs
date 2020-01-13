using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_prototipo
{
    class CAuto
    {
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public CAuto(string pModelo, int pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }


        public override string ToString() // hacemos el overrai de dato string
        {
            return string.Format("{0}, {1}", modelo, costo);

        }
        public object Clonar()  // se implementa el clonar en el cual se esta aprovechando el costructor para 
                                 //llevar a cabo la copia del objeto
        {
            CAuto clon = new CAuto(modelo, costo);
            return clon;
        }

    }
}
