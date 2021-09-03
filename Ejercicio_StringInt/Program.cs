using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir por consola el nombre de una persona y la edad y mostrar en pantalla el siguiente mensaje: 
            //"Te llamas" <nombre> "y tienes: " <edad> "aÑos" 

            string nombre, edad;
            Console.WriteLine("Te llamas");
            nombre = Console.ReadLine();
            Console.WriteLine("Y tienes");
            edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + nombre + " Y tienes " + edad + " años ");
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
            




        }
    }
}
