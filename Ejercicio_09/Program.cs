using System;

namespace Ejercicio_09{
    class Program{
        static void Main(string[] args){

            int altura;
            int alturaNeg = 0;

            Console.WriteLine("Ingrese la altura de el triangulo: ");
            while (!(int.TryParse(Console.ReadLine(), out altura))){
                Console.WriteLine("ERROR, Ingrese la altura de el triangulo: ");
            }

            for (int i = 0; i <= altura; i++){
                Console.Write("\n");
                int espacio = altura - 1 / 2;
                for (int k = 0; k < espacio - alturaNeg; k++){
                    Console.Write(" ");
                }
                for (int j = 0; j < i + i - 1; j++){
                    Console.Write("*");
                }
                alturaNeg++;
            }

        }
    }
}
