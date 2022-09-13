using System;

namespace Ejercicio_04{
    class Program{
        static void Main(string[] args){

            int numBuscados = 4;
            int suma = 0;

            Console.Write("Los numeros perfectos son: ");
            
            for (int i = 2; numBuscados > 0; i++) {
                suma = 0;
                for (int j = 1; j < i; j++) {
                    if (i % j == 0) {
                        suma += j;
                    }
                }
                
                if (i == suma) {
                    Console.WriteLine(i);
                    numBuscados--;
                }
            }
        }
    }
}
