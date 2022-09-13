using System;

namespace Ejercicio_03
{
    class Program{
        static void Main(string[] args){

            int numIngresado;
            bool primo = true;
            string respuesta = "";

            Console.Write("Ingrese un numero: ");
            while (!(int.TryParse(Console.ReadLine(), out numIngresado))){
                Console.Write("ERROR, para salir ingrese -salir-, si desea continuar pulse cualquier tecla ");
                respuesta = Console.ReadLine();
                if (respuesta == "salir") {
                    break;
                }
                Console.Write("Ingrese un numero: ");
            }

            if (respuesta != "salir") {
                for (int i = 1; i < numIngresado; i++) {
                    for (int j = 2; j < i; j++){
                        if (i % j == 0){
                            primo = false;
                            break;
                        }
                    }
                    if (primo == true) {
                        Console.WriteLine("{0} ", i);
                    }
                    primo = true;
                }
            }
        }
    }
}
