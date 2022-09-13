using System;

namespace Ejercicio_01{
    class Ejercicio_01{
        static void Main(string[] args){
            int numeroCargado;
            int numMax = 0;
            int numMin = 0;
            int sumaTotal = 0;
            float promedio;
            int cargas = 5;
            int numerosCargados;

            Console.WriteLine("¿Cuantas veces desea cargar?: ");
            cargas = int.Parse(Console.ReadLine());
            numerosCargados = cargas;

            do {
                Console.WriteLine("Ingrese el numero: ");
                numeroCargado = int.Parse(Console.ReadLine());
                sumaTotal += numeroCargado;

                if (cargas == numerosCargados){
                    numMax = numeroCargado;
                    numMin = numeroCargado;
                } else {
                    if (numeroCargado < numMin){
                        numMin = numeroCargado;
                    } else if(numeroCargado > numMax) {
                        numMax = numeroCargado;
                    }
                }
                cargas--;
            } while (cargas > 0);

            promedio = (float)sumaTotal / numerosCargados;

            Console.WriteLine("El numero maximo es {0}, el minimo es: {1} y el promedio es: {2}", numMax, numMin, promedio);

        }
    }
}
