using System;
using System.Collections.Generic; // se necesita tener esto, se puede cualquier otra estructura para resolver el problema
using System.Text;

namespace Patron_prototipo
{
    class CAdminPrototipos
    {
         // para esta clase en particular se va a utilizar una coleccion que se conoce como diccionario, con cual se puede identificar
         // el prototipo por medio de una palabra o cadena

        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipos()
        {
            // adicionamos los objetos prototipos con los valores iniciales que nos interesen

            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionarPrototipo(string pLlave, IPrototipo pPrototipo) // Se crea el prototipo adiciona prototipo el cual resive
            //los parametros es decir los catalosgo
        {
            prototipos.Add(pLlave, pPrototipo); // se adicionan
        }

        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar(); // se retorna la instancia , al la cual se le envoca la el metodo clonar con el cual nos regresa 
            // ese clon para enviar le al cliente el clon correspondiente 
        }
    }


}
