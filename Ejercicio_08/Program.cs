using System;

namespace Ejercicio_08{
    class Program{
        static void Main(string[] args){

            int altura;

            Console.WriteLine("Ingrese la altura de el triangulo: ");
            while (!(int.TryParse(Console.ReadLine(), out altura))) {
                Console.WriteLine("ERROR, Ingrese la altura de el triangulo: ");
            }

            for (int i = 0; i <= altura; i++) {
                Console.Write("\n");
                for (int j = 0; j < i + i - 1; j++) {
                    Console.Write("*");
                }
            }
        }
    }
}
