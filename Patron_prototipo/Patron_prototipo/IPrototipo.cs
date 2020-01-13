using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_prototipo
{
    interface IPrototipo // se crea una interfas prototipo
    {
        //lleva un metodo clonar, el cual va a retornar o regresar alguien de tipo oyed que va hacer el clon que se va a obtener
        object Clonar();
    }
}
