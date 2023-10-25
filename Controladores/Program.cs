using Ejercicio1Bucles.Servicios;

namespace Ejercicio1Bucles
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Declaro la variable
            int numero, suma;

            //Instancio las dos interfaces con sus implementaciones
            PedirNumeroInterfaz pni = new PedirNumeroImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            //Solicito el número entero por consola
            numero = pni.pedirNumero();

            //Calculo la suma total
            suma = oi.sumaNumeros(numero);
        }
    }
}
