using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args){

            int numeroIngresado;
            double numeroCuadrado;
            double numeroCubo;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            while (numeroIngresado <= 0) {
                Console.Write("ERROR. Ingrese un numero nuevamente: ");
                numeroIngresado = int.Parse(Console.ReadLine());
            }

            numeroCuadrado = Math.Pow(numeroIngresado, 2);
            numeroCubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El cuadrado es: {0} y su cubo es: {1}", numeroCuadrado, numeroCubo);

        }
    }
}
