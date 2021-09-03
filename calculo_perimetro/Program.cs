using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 7;
            int p = a + b + c;
            Console.WriteLine("el perimetro del triangulo es:" + p);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
