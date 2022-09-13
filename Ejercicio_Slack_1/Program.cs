using System;
using LibreriaEj_1;

namespace Ejercicio_Slack_1{
    class Program{
        static void Main(string[] args){
            Cosa cosa = new Cosa();
            DateTime fecha = new DateTime(2022, 07, 26);

            cosa.EstablecerValor(20);
            cosa.EstablecerValor("Parcial");
            cosa.EstablecerValor(fecha);

            Console.WriteLine(Cosa.Mostrar(cosa));
        }
    }
}
