using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Bucles.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public int sumaNumeros(int numero)
        {
            int suma = 0;
            for (int i = 0; i <= numero; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma de todos los números hasta " + numero + " es : " + suma);
            return suma;
        }
    }
}
