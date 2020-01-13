using System;

namespace Patron_prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            // crearemos el administrador, la instancia
            CAdminPrototipos admin = new CAdminPrototipos();

            // obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona"); // se mandan al admistrador pro..instancias y se guardan en uno
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            // verificamos que tengan los valores del prototipo original

            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine(".......");

            //modificamos el estado
            uno.Nombre = "Javier";
            dos.Nombre = "Juan";

            // verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("......");

        }
    }
}







            ////crearemos una instancia
            
            //CAuto auto = new CAuto("Ford", 60000);

            //// lo colocamos como prototipo

            //admin.AdicionarPrototipo("Auto", auto);


            //// obtenemos un objeto de ese prototipo

            //CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //// cambiamos el estado

            //auto2.Modelo = "Ford";

            //// verificamos que cada uno tenga su estado 

            //Console.WriteLine(auto);
            //Console.WriteLine(auto2);
            //Console.WriteLine(".....");

            


        
