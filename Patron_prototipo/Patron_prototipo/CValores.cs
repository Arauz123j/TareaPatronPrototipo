using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_prototipo
{
    class CValores : IPrototipo
    {
        // simulamos que esta es una clase que tiene un constructor costoso
        private double sumatoria;

        public double Sumatoria
        {
            get { return sumatoria; }
            set { sumatoria = value; }
        }
        private int m;

        public int M
        {
            get { return m; }
            set { m = value; }
        }

        // constructor CValores, vacio

        public CValores()
        {
                
        }

        // este es el constructor costoso
        public CValores(int pM)
        {
            m = pM;
            int n = 0;
            for (n = 0; n < 90; n++)
                sumatoria += Math.Sin(n * 0.0175);
        }

        // se crea un override dato string el cual va a retornar el valor de sumatoria por m
        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }


        // se crea el metodo clonar 
        public object Clonar()
        {
            CValores clon = new CValores(); // para clonar se crea una instancia que contiene el cosntructor CValores vacio
            clon.M = m; // se copia el estado de la instancia a la nueva instacia 
            clon.Sumatoria = sumatoria; 

            return clon;

        }
       
    }
}
