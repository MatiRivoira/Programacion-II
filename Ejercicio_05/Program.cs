using System;

namespace Ejercicio_05{
    class Program{
        static void Main(string[] args){

            int num;
            int sumaAntes = 0;
            int sumaDespues = 0;

            Console.WriteLine("Ingrese un numero");

            while (int.TryParse(Console.ReadLine(), out num)) {
                //recorro los numeros desde el 1 hasta el numero ingresado
                for (int centro = 1; centro < num; centro++) {
                    //sumo los numeros anteriores
                    for (int i = 0; i < centro; i++) {
                        sumaAntes += i;
                    }

                    //sumo los numeros superiores al centro
                    for (int j = centro +1; j <= sumaAntes; j++) {
                        if ((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                            break;

                        sumaDespues += j;
                    }

                    //mostrar por pantalla
                    if (sumaAntes == sumaDespues) {
                        Console.WriteLine("Es un centro numerico: {0}", centro);
                    }
                }
            }
            Console.WriteLine("No es un numero");
            Console.ReadKey();
        }
    }
}
