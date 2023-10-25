using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Bucles.Servicios
{
    internal class PedirNumeroImplementacion : PedirNumeroInterfaz
    {
        /// <summary>
        /// Método para pedir un número entero al usuario por consola
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumero()
        {
            int numero;
            //Utilizamos un do...while para controlar que el número que se introduzca por consola sea mayor que cero
            do
            {
                Console.WriteLine("Escribe un número entero mayor que cero:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero <= 0);


            return numero;
        }
    }
}
