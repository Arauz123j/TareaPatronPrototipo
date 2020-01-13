using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_prototipo
{
    class CPersona:IPrototipo
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;

        public int Edad 
        {
            get { return edad; }
            set { edad = value; }
        }
        public CPersona (string pNombre , int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre,edad);

        }
        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, edad);
            return clon;
        }
    }
}
