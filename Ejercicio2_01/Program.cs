using System;

namespace Ejercicio_01{
    class Program{
        static void Main(string[] args){
            
            int numero;
            int min = 0;
            int max = 0;
            
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Ingrese un numero: ");
                while (!(int.TryParse(Console.ReadLine(), out numero)) || Validador.Validar(numero, -100, 100)) {
                    Console.WriteLine("ERROR, Ingrese otro numero: ");
                }
                if (i == 0)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    else if (numero > max)
                    {
                        max = numero;
                    }
                }
            }
        }
    }
}
