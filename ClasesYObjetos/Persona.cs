using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYObjetos //ruta
{
    //la clase se crea en un archivo nuevo
    //Proyecto --> agregar clase
    class Persona
    {
        //atajo para crear una propiedad, escribir prop

        //public es que se puede utilzar en todo el proyecto
        //primer latre de un propiedad en Mayuscula
        //get obtener dato, set guardar dato
        public string Nombre { get; set; } //propiedades, son como una variable con funcionalidades extras
        public int Edad { get; set; }

        //constructor, permite inicializar datos
        //atajo para crear un constructor, escribir ctor
        //constructor se debe llamar igual que la clase, tiene que estar dentro de la clase
        //constructor vacio existe por defecto

        public Persona(string nombre,int edad) //constructor con datos, si no tiene parametros es vacio
        {
            //constructor funcion inicializar datos
            //propiedad contiene el dato que tiene el atributo
            Nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            //hace un get para obtener el Nombre y Edad de la clase
            //get tiene un return
            Console.WriteLine("Mi nombre es " + Nombre + " y tengo " + Edad + " años");
        }




    }
}
