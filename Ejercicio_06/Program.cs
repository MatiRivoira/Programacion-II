using System;

namespace Ejercicio_06{
    class Program{
        static void Main(string[] args){

            int añoInicial;
            int añoFinal;

            Console.WriteLine("Ingrese el año inicial: ");
            while (!(int.TryParse(Console.ReadLine(), out añoInicial))) {
                Console.WriteLine("ERROR, Ingrese el año inicial: ");
            }

            Console.WriteLine("Ingrese el año Final: ");
            while (!(int.TryParse(Console.ReadLine(), out añoFinal))){
                Console.WriteLine("ERROR, Ingrese el año final: ");
            }

            Console.WriteLine("Los años biciestos en ese rango son: ");

            for (int i = añoInicial; i <= añoFinal; i++) {
                if ((i % 4 == 0) || (i % 100 == 0 && i % 400 == 0)) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
