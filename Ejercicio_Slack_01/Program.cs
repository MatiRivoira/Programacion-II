using System;

namespace Ejercicio_Slack_01{
    class Program{
        static void Main(string[] args){
            Sello.mensaje = "hola mundo";
            Console.WriteLine(Sello.Imprimir());
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}
