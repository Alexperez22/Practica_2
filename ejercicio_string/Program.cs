using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;
            Console.WriteLine("escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("hi " + nombre + " bienbenido a " + ciudad);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
